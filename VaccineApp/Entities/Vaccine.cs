namespace VaccineApp.Entities
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Vaccine
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(150)]
        public string Description { get; set; }

        [ForeignKey("BodyPart")]
        public int BodyPartId { get; set; }

        public BodyPart BodyPart { get; set; }
        public int CompanyId { get; set; }
        public VaccineCompany Company { get; set; }
    }
}