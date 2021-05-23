namespace VaccineApp.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;

    public class AppointmentStatus
    {
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string Status { get; set; }
    }
}