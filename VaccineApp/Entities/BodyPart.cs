namespace VaccineApp.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;

    public class BodyPart
    {
        public int Id { get; set; }

        [StringLength(30)]
        public string Name { get; set; }
    }
}