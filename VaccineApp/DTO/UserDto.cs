namespace VaccineApp.DTO
{
    using Entities;
    using System;
    using System.Collections.Generic;

    public class UserDto
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }
        public DateTime BirthDate { get; set; }
        public List<Appointment> Appointments { get; set; }
    }
}