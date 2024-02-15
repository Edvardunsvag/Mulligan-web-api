﻿using Microsoft.AspNetCore.Mvc;
using MulliganApi.Authentication;
using MulliganApi.Database.Models;
using MulliganApi.Dto;
using MulliganApi.Service;

namespace MulliganApi.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    [ServiceFilter(typeof(ApiKeyAuthFilter))]
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
        public List<RoundGetDto> GetAllRoundsForUser(Guid id)
        {
            var rounds = _service.GetAllRoundsForUser(id).OrderByDescending(x => x.Date).ToList();
            return rounds;
        }

        [HttpGet("GetAllRounds")]
        public List<RoundGetDto> GetAllRounds()
        {
            var rounds = _service.GetAllRounds();
            return rounds;
        }
    }
}
