using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VaccineApp.Entities
{
    public class Appointment
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public VaccinationCenter Location { get; set; }
        public Vaccine Vaccination { get; set; }
        public AppointmentStatus Status { get; set; }
    }
}