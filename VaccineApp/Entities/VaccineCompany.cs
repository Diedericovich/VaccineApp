﻿namespace VaccineApp.Entities
{
    using System.ComponentModel.DataAnnotations;

    public class VaccineCompany
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Country { get; set; }

        public bool IsEmaApproved { get; set; }
    }
}