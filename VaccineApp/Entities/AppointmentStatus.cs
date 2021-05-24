namespace VaccineApp.Entities
{
    using System.ComponentModel.DataAnnotations;

    public class AppointmentStatus
    {
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string Status { get; set; }
    }
}