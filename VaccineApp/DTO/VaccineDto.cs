namespace VaccineApp.DTO
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Entities;

    public class VaccineDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string BodyPart { get; set; }

        public string CompanyName { get; set; }
    }
}