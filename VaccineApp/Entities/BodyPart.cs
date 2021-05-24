namespace VaccineApp.Entities
{
    using System.ComponentModel.DataAnnotations;

    public class BodyPart
    {
        public int Id { get; set; }

        [Required]
        [StringLength(30)]
        public string Name { get; set; }
    }
}