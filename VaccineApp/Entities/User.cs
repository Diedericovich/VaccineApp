namespace VaccineApp.Entities
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class User
    {
        public string Address { get; set; }

        public List<Appointment> Appointments { get; set; }

        public DateTime BirthDate { get; set; }

        public string FirstName { get; set; }

        public int Id { get; set; }

        public Login Login { get; set; }

        public string Surname { get; set; }
    }
}