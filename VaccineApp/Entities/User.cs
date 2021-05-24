namespace VaccineApp.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class User
    {
        public int Id { get; set; }
        public int LoginId { get; set; }
        public Login Login { get; set; }

        [Required]
        [StringLength(100)]
        public string Email { get; set; }

        [Required]
        [StringLength(30)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(55)]
        public string Surname { get; set; }

        [Required]
        [StringLength(100)]
        public string Address { get; set; }

        public DateTime BirthDate { get; set; }

        public List<Appointment> Appointments { get; set; } = new List<Appointment>();
    }
}