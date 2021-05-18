namespace VaccineApp.Entities
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Vaccine
    {
        public int Id { get; set; }

        [StringLength(50)]
        [Required]
        public string Name { get; set; }

        [StringLength(150)]
        [Required]
        public string Description { get; set; }

        [ForeignKey("BodyPart")]
        public int BodyPartId { get; set; }

        public BodyPart BodyPart { get; set; }
        public int CompanyId { get; set; }
        public VaccineCompany Company { get; set; }
    }
}