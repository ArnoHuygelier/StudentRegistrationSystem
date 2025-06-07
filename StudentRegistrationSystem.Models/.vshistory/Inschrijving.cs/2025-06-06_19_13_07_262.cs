using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegistrationSystem.Models
{
    public class Inschrijving
    {
        public required int StudentId { get; set; }
        public required Student Student { get; set; }
    }
}
