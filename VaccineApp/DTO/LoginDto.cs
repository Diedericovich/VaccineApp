namespace VaccineApp.DTO
{
    using System.ComponentModel.DataAnnotations;

    public class LoginDto
    {
        [Required]
        [MinLength(4)]
        [MaxLength(50)]
        public string Password { get; set; }

        [Required]
        [MinLength(4)]
        [MaxLength(100)]
        public string Email { get; set; }
    }
}