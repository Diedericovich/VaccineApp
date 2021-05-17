namespace VaccineApp.Entities
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class Vaccine
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public BodyPart BodyPart { get; set; }

        public VaccineCompany Company { get; set; }
    }
}