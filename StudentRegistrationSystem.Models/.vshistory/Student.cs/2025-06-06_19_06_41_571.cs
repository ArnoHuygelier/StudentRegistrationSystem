using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegistrationSystem.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Voorname { get; set; }
        public string Achternaam { get; set; }
        public string Email { get; set; }
    }
}
