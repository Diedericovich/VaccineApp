namespace VaccineApp.DTO
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class RegisterDto
    {
        public string Password { get; set; }

        public string Email { get; set; }

        public string FirstName { get; set; }

        public string SurName { get; set; }

        public string Address { get; set; }

        public DateTime BirthDate { get; set; }
    }
}