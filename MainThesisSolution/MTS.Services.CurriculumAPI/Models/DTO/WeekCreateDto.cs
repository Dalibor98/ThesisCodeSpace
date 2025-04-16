using System.ComponentModel.DataAnnotations;

namespace MTS.Services.CurriculumAPI.Models.DTO
{
    public class WeekCreateDto
    {
        [Required]
        public string CourseCode { get; set; }

    }
}
