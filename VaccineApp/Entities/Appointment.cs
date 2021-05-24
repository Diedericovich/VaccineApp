namespace VaccineApp.Entities
{
    using System;

    public class Appointment
    {
        public int Id { get; set; }
        public int UserId { get; set; }

        public DateTime Date { get; set; }
        public int LocationId { get; set; }
        public VaccinationCenter Location { get; set; }
        public int VaccinationId { get; set; }
        public Vaccine Vaccination { get; set; }
        public int StatusId { get; set; }
        public AppointmentStatus Status { get; set; }
    }
}