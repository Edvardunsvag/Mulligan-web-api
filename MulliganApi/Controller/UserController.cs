using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using Azure.Core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MulliganApi.Database.Enums;
using MulliganApi.Database.Models;
using MulliganApi.Database.Repository;
using MulliganApi.Dto;
using MulliganApi.Service;

namespace MulliganApi.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMulliganService _service;
        private readonly IMulliganRepository _repository;

        public UserController(IMulliganService service, IMulliganRepository repository)
        {
            _service = service;
            _repository = repository;
        }

        [HttpPost("register")]
        public async Task<ActionResult<UserDto>> Register(UserRegisterRequestDto request)
        {
            var registeredUsers = _repository.GetAllUsers();
            if (registeredUsers.Any(u => u.Username == request.Username))
            {
                return BadRequest("Brukernavnet er tatt");
            }
            if (request.Password.Length < 6)
            {
                return BadRequest("Passordet må være lenger enn 6 tegn");
            }
            if (request.Password != request.ConfirmPassword)
            {
                return BadRequest("Passordene matcher ikke");
            }
            if (request.Username.Length < 6)
            {
                return BadRequest("Brukernavn må være lenger enn 6 tegn");
            }

            CreatePasswordHash(request.Password,
                out byte[] passwordHash, out byte[] passwordSalt);

            var user = new User
            {
                Username = request.Username,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                VerificationToken = CreateRandomToken()
            };

            await _repository.AddUser(user);
            var userDto = new UserDto()
            {
                UserId = user.Id,
                Name = user.Username,
            };

            return Ok(userDto);
        }

        [HttpPost("login")]
        public ActionResult<UserDto> Login(UserLoginRequestDto request)
        {
            var registeredUsers = _repository.GetAllUsers();
            var user = registeredUsers.FirstOrDefault(u => u.Username == request.Username);
            if (user == null)
            {
                return BadRequest("Fant ikke brukeren");
            }

            if (!VerifyPasswordHash(request.Password, user.PasswordHash, user.PasswordSalt))
            {
                return BadRequest("Feil passord");
            }
            var userDto = new UserDto()
            {
                UserId = user.Id,
                Name = user.Username,
            };

            return Ok(userDto);
        }

        [HttpPost("registerGoogleSignin")]
        public async Task<ActionResult<UserDto>> RegisterGoogleSignin(string? username, string? authToken,
            string? email, LoginProviderEnum loginProvider)
        {
            var registeredUsers = _repository.GetAllUsers();
            var userByAuthToken = registeredUsers.FirstOrDefault(x => x.VerificationToken == authToken);
            var userByEmail = registeredUsers.FirstOrDefault(x => x.Email == email);
            UserDto userDto;
            if (loginProvider == LoginProviderEnum.Apple)
            {
                //Add user with first apple login
                if (userByAuthToken == null && username != null && authToken != null && userByEmail == null)
                {
                    var newGuid = Guid.NewGuid();
                    var userToAdd = new User
                    {
                        Id = newGuid,
                        Username = username,
                        VerificationToken = authToken,
                        Email = email
                    };
                    await _repository.AddUser(userToAdd);
                    userDto = new UserDto
                    {
                        UserId = newGuid,
                        Name = username,
                    };
                    return Ok(userDto);
                }

                //User is already added with apple
                if (userByAuthToken != null)
                {
                    userDto = new UserDto
                    {
                        UserId = userByAuthToken.Id,
                        Name = userByAuthToken.Username,
                    };
                    return Ok(userDto);
                }

                //User is already added with google
                if (userByEmail != null)
                {
                    var userToUpdate = new User
                    {
                        Id = userByEmail.Id,
                        Username = userByEmail.Username,
                        VerificationToken = authToken,
                        Email = email
                    };
                    userByEmail.VerificationToken = authToken;
                    await _repository.UpdateUser(userToUpdate);
                    userDto = new UserDto
                    {
                        UserId = userByEmail.Id,
                        Name = userByEmail.Username,
                    };
                    return Ok(userDto);
                }
            }

            if (loginProvider == LoginProviderEnum.Google)
            {
                //Add user with first google login
                if (authToken == null && userByEmail == null && userByAuthToken == null)
                {
                    var newGuid = Guid.NewGuid();
                    var userToAdd = new User
                    {
                        Id = newGuid,
                        Username = username,
                        VerificationToken = authToken,
                        Email = email
                    };
                    await _repository.AddUser(userToAdd);
                    userDto = new UserDto
                    {
                        UserId = newGuid,
                        Name = username,
                    };
                    return Ok(userDto);
                }

                //User is already added with google
                if (userByEmail != null || userByAuthToken != null)
                {
                    userDto = new UserDto
                    {
                        UserId = userByEmail.Id,
                        Name = userByEmail.Username,
                    };
                    return Ok(userDto);
                }
            }
            userDto = new UserDto
            {
                UserId = userByEmail.Id,
                Name = userByEmail.Username,
            };
            
            return Ok(userDto);
        }
    

        [HttpGet("GetUserId")]
        public ActionResult<List<User>> GetUserId(string username)
        {
            var registeredUsers = _repository.GetAllUsers();
            var user = registeredUsers.FirstOrDefault(u => u.Username == username);

            if (user == null)
            {
                return BadRequest("User not found");
            }

            return Ok(registeredUsers);
        }

        [HttpGet("GetAllUsers")]
        public ActionResult<List<User>> GetAllUsers()
        {
            var registeredUsers = _repository.GetAllUsers();
            if(registeredUsers.Count == 0)
            {
                return BadRequest("No users");
            }

            return Ok(registeredUsers);
        }
        
        private static void CreatePasswordHash(string password,
            out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }

        private bool VerifyPasswordHash(string password,
            byte[] passwordHash, byte[] passwordSalt)
        {
            using (var hmac = new HMACSHA512(passwordSalt))
            {
                var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                return computedHash.SequenceEqual(passwordHash);
            }
        }

        private static string CreateRandomToken()
        {
            return Convert.ToHexString(RandomNumberGenerator.GetBytes(64));
        }
    }
}
