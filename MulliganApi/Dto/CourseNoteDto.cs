﻿using static MulliganApi.Service.MulliganService;

namespace MulliganApi.Dto
{
    public class CourseNoteDto
    {
        public string CourseName { get; set; }
        public string NumberOfHolesWithNotes { get; set; }
        public List<CourseHoleNoteDto> NotesForAllHoles { get; set; }
    }
}
