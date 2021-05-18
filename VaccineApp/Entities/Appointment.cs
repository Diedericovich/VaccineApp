namespace VaccineApp.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Threading.Tasks;

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