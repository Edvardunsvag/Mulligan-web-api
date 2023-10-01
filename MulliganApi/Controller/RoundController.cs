using Microsoft.AspNetCore.Mvc;
using MulliganApi.Database.Models;
using MulliganApi.Dto;
using MulliganApi.Service;

namespace MulliganApi.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoundController
    {
        private readonly IMulliganService _service;
        public RoundController(IMulliganService service)
        {
            _service = service;
        }

        [HttpPost()]
        public async Task<Round> AddRound(RoundPostDto round)
        {
            var output = await _service.AddRound(round);
            return output;
        }

        [HttpGet("GetAllRoundsForUser")]
        public async Task<List<RoundGetDto>> GetAllRoundsForUser(Guid id)
        {
            var rounds = await _service.GetAllRoundsForUser(id);
            return rounds;
        }

        [HttpGet("GetAllRounds")]
        public async Task<List<RoundGetDto>> GetAllRounds()
        {
            var rounds = await _service.GetAllRounds();
            return rounds;
        }


    }
}
