﻿namespace MTS.Services.UserAPI.Models.DTO
{
    public class StudentDto : UserDto
    {
        public string Major { get; set; }
        public int EnrollmentYear { get; set; }
    }
}
