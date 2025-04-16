﻿using System.ComponentModel.DataAnnotations;

namespace MTS.Web.Models.Curriculum.Assignment
{
    public class AssignmentCreateDto
    {
        public string CourseCode { get; set; }
        public string WeekCode { get; set; }

        [Required]
        [Display(Name = "Assignment Title")]
        public string Title { get; set; }

        [Required]
        [Display(Name = "Description")]
        public string Description { get; set; }

        [Required]
        [Display(Name = "Maximum Points")]
        [Range(1, 100, ErrorMessage = "Maximum points must be between 1 and 100")]
        public int MaxPoints { get; set; } = 100;

        [Required]
        [Display(Name = "Minimum Points to Pass")]
        [Range(0, 100, ErrorMessage = "Minimum points must be between 0 and 100")]
        public int MinPoints { get; set; } = 60;

        [Required]
        [Display(Name = "Due Date")]
        public DateTime DueDate { get; set; }
    }
}