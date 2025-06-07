using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegistrationSystem.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public required string Voorname { get; set; }
        [Required]
        public required string Achternaam { get; set; }
        [Required]
        public required string Email { get; set; }
    }
}
