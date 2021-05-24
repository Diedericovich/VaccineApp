namespace VaccineApp.DTO
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class RegisterDto
    {
        [Required]
        public string Password { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string SurName { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }
    }
}