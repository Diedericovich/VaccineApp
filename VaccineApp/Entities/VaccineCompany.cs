using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VaccineApp.Entities
{
    public class VaccineCompany
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public bool IsEmaApproved { get; set; }
    }
}