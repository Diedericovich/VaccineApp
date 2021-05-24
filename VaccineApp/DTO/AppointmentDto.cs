namespace VaccineApp.DTO
{
    using Entities;
    using System;

    public class AppointmentDto
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public VaccinationCenter Location { get; set; }

        public VaccineDto Vaccination { get; set; }

        public AppointmentStatus Status { get; set; }
    }
}