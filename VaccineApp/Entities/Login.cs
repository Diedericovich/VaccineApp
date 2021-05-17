using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VaccineApp.Entities
{
    public class Login
    {
        public int Id { get; set; }
        public string Password { get; set; }
        public string EMail { get; set; }
    }
}