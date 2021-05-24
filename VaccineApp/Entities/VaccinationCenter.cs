namespace VaccineApp.Entities
{
    using System.ComponentModel.DataAnnotations;

    public class VaccinationCenter
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(100)]
        public string Location { get; set; }
    }
}