namespace VaccineApp.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;

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