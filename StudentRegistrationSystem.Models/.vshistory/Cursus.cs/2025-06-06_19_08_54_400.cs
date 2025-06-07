using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegistrationSystem.Models
{
    public class Cursus
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public required string Titel { get; set; }
        public int Studiepunten { get; set; }
        public int DocentId { get; set; }

    }
}
