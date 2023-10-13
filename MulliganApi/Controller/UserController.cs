using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using Azure.Core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MulliganApi.Data;
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
        public async Task<ActionResult<Guid>> Register(UserRegisterRequestDto request)
        {
            var registeredUsers = await _repository.GetAllUsers();

            if (registeredUsers.Any(u => u.Email == request.Email))
            {
                return BadRequest("User already exists");
            }

            CreatePasswordHash(request.Password,
                out byte[] passwordHash, out byte[] passwordSalt);

            var user = new User
            {
                Email = request.Email,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                VerificationToken = CreateRandomToken()
            };

            await _repository.AddUser(user);

            return user.Id;
        }

        [HttpPost("login")]
        public async Task<ActionResult<Guid>> Login(UserLoginRequestDto request)
        {
            var registeredUsers = await _repository.GetAllUsers();

            var user = registeredUsers.FirstOrDefault(u => u.Email == request.Email);
            if (user == null)
            {
                return BadRequest("User not found");
            }

            if (!VerifyPasswordHash(request.Password, user.PasswordHash, user.PasswordSalt))
            {
                return BadRequest("Password is incorrect");
            }

            return user.Id;
        }

        [HttpPost("registerGoogleSignin")]
        public async Task<IActionResult> RegisterGoogleSignin(string email)
        {
            var registeredUsers = await _repository.GetAllUsers();
            var user = registeredUsers.FirstOrDefault(u => u.Email == email);
            if (user != null)
            {
                return BadRequest("User already exists");
            }

            var userToAdd = new User
            {
                Email = email,
            };
            await _repository.AddUser(userToAdd);

            return Ok("User successfully created");
        }

        [HttpGet("GetUserId")]
        public async Task<IActionResult> GetUserId(string email)
        {
            var registeredUsers = await _repository.GetAllUsers();
            var user = registeredUsers.FirstOrDefault(u => u.Email == email);

            if (user == null)
            {
                return BadRequest("User not found");
            }

            return Ok(registeredUsers);
        }

        [HttpGet("GetAllUsers")]
        public async Task<IActionResult> GetAllUsers()
        {
            var registeredUsers = await _repository.GetAllUsers();
            if(registeredUsers.Count == 0)
            {
                return BadRequest("No users");
            }

            return Ok(registeredUsers);
        }
        
        private void CreatePasswordHash(string password,
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
