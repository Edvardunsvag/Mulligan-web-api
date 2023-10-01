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

        [HttpGet("GetAllNotesForUser")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<NoteDto>))]
        public async Task<IResult> GetAllCourses(Guid userId)
        {
            var notesForCourse = await _service.GetAllNotesForUser(userId);
            return Results.Ok(notesForCourse);
        }

        [HttpPost("AddNote")]
        public async Task<IResult> AddNote(NotePostDto note)
        {
            
            //Get data
            var courses = await _repository.GetAllCourses();
            var connectedCourse = courses.Where(c => c.Id == note.CourseId);

            //Create the note
            var newNote = new Note()
            {
                Content = note.Content,
                LastUpdated = DateTime.Now,
                UserId = note.UserId,

            };

            //Add note
            await _repository.AddNote(newNote);
            await _repository.Save();

            return Results.Ok(newNote);
        }


    }
}
