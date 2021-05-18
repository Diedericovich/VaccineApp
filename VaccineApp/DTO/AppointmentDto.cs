namespace VaccineApp.DTO
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Entities;

    public class AppointmentDto
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public VaccinationCenter Location { get; set; }

        public Vaccine Vaccination { get; set; }

        public AppointmentStatus Status { get; set; }
    }
}