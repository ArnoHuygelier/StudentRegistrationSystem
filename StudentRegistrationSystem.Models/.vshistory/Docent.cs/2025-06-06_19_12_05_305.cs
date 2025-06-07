using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegistrationSystem.Models
{
    public class Docent
    {
        //Id, Naam, Email
        [Key]
        public int Id { get; set; }

        [Required]
        public required string Name { get; set; }
        public required string Email { get; set; }
    }
}
