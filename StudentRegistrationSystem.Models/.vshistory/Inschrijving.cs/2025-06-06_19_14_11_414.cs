using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegistrationSystem.Models
{
    [PrimaryKey]
    public class Inschrijving
    {
        public required int StudentId { get; set; }
        public required Student Student { get; set; }

        public required int CursusId { get; set; }
        public required Cursus Cursus { get; set; }
    }
}
