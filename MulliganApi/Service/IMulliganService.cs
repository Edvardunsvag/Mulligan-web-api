﻿using MulliganApi.Database.Models;
using MulliganApi.Dto;

namespace MulliganApi.Service
{
    public interface IMulliganService
    {
        //Course
        List<CourseInfoDto> GetInfoAboutCourses();
        List<Guid> GetAllCourseIds();
        List<ScoreBoardRound> GetAllRoundsForCourse(Guid courseId);

        List<CourseRoundHoleStatsDto> GetAllScoresForCourseHole(Guid userId, Guid courseId);
        CourseGeneralStats GetCourseGeneralStats(Guid userId, Guid courseId);

        //Rounds
        List<RoundGetDto> GetAllRoundsForUser(Guid id);
        List<RoundGetDto> GetAllRounds();
        RoundGetDto GetRound(Guid roundId);
        Task<Round> AddRound(RoundPostDto round);

        //Notes
        List<CourseNoteDto> GetAllNotesForUser(Guid userId);
        CourseNoteDto GetAllNotesForCourse(Guid userId, Guid courseId);

    }
}
