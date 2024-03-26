using Microsoft.AspNetCore.Mvc;
using MulliganApi.Authentication;
using MulliganApi.Database.Models;
using MulliganApi.Database.Repository;
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
        private readonly IMulliganRepository _repository;
        public RoundController(IMulliganService service, IMulliganRepository repository)
        {
            _service = service;
            _repository = repository;
        }
        
        [HttpGet("GetAllRoundsForUser")]
        public List<RoundGetDto> GetAllRoundsForUser(Guid id)
        {
            var rounds = _service.GetAllRoundsForUser(id).OrderByDescending(x => x.Date).ToList();
            return rounds;
        }
        
        [HttpGet("GetRound")]
        public RoundGetDto GetRound(Guid roundId)
        {
            var round = _service.GetRound(roundId);
            return round;
        }

        [HttpGet("GetAllRounds")]
        public List<RoundGetDto> GetAllRounds()
        {
            var rounds = _service.GetAllRounds();
            return rounds;
        }
        
        [HttpGet("GetAllRoundsForScoreBoard")]
        public List<ScoreBoardRound> GetAllRoundsForScoreBoard()
        {
            var courseRounds = _service.GetAllRoundsForScoreBoard();
            return courseRounds;
        }
        
        [HttpGet("GetDataForScoreBoard")]
        public List<ScoreBoardCourseCard> GetDataForScoreBoard(Guid userId)
        {
            var courseRounds = _service.GetDataForScoreBoard(userId);
            return courseRounds;
        }

        [HttpPost()]
        public async Task<Round> AddRound(RoundPostDto round)
        {
            var output = await _service.AddRound(round);
            return output;
        }
        
        [HttpDelete("DeleteRound")]
        public async Task<ActionResult<Guid>> DeleteRound(Guid roundId)
        {
            var round = _repository.GetRound(roundId);
            var deletedRound = await _repository.DeleteRound(round);
            await _repository.Save();

            return deletedRound;
        }
    }
}
