﻿namespace MulliganApi.Dto
{
    public class NotePostDto
    {
        public Guid UserId { get; set; }
        public string Content { get; set; }
        public Guid HoleId { get; set; }
    }
}
