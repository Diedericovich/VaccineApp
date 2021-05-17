using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using VaccineApp.Entities;

namespace VaccineApp.DTO
{
    public class UserDto
    {
        public string Address { get; set; }

        public List<Appointment> Appointments { get; set; }

        public DateTime BirthDate { get; set; }

        public string Email { get; set; }

        public string FirstName { get; set; }

        public int Id { get; set; }

        public string Surname { get; set; }
    }
}