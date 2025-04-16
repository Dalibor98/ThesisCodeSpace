﻿namespace MTS.Services.CurriculumAPI.Models
{
    public class StudentQuizAttempt
    {
        public int Id { get; set; }
        public string QuizCode { get; set; }
        public string StudentUniversityId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int Score { get; set; }
        public string AttemptCode { get; set; } 
    }
}
