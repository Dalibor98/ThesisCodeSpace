﻿namespace MTS.Services.CurriculumAPI.Models.DTO.QuizDto
{
    public class QuizCreateDto
    {
        public string WeekCode { get; set; }
        public string CourseCode { get; set; }
        public string Title { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int TimeLimit { get; set; } // In minutes
        public string QuizType { get; set; } // "MultipleChoice" or "TextBased"

    }
}
