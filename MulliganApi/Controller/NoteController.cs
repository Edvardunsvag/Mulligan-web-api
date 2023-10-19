using Microsoft.AspNetCore.Mvc;
using MulliganApi.Database.Models;
using MulliganApi.Database.Repository;
using MulliganApi.Dto;
using MulliganApi.Service;

namespace MulliganApi.Controller
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class NoteController
    {
        private readonly IMulliganService _service;
        private readonly IMulliganRepository _repository;

        public NoteController(IMulliganService service, IMulliganRepository repository)
        {
            _service = service;
            _repository = repository;
        }

        [HttpGet()]
        public ActionResult<List<CourseNoteDto>> GetAllNotes([FromQuery] Guid userId)
        {
            var notesForCourse =  _service.GetAllNotesForUser(userId);
            return notesForCourse;
        }

        [HttpPost("AddNote")]
        public async Task<IResult> AddNote(NotePostDto note)
        {
            //Get data  
            var connectedHole =  _repository.GetHoleById(note.HoleId);

            //Create the note
            var newNote = new Note()
            {
                HoleId = connectedHole.Id,
                LastUpdated = DateTime.UtcNow,
                Id = Guid.NewGuid(),
                NoteText = note.Content,
                UserId = note.UserId,
            };

            //Add note
            await _repository.AddNote(newNote);
            await _repository.Save();

            return Results.Ok();
        }
    }
}
