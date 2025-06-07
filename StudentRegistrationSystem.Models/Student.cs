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
        public required string Voornaam { get; set; }

        [Required]
        public required string Achternaam { get; set; }

        [Required]
        [EmailAddress]
        public required string Email { get; set; }

        public List<Inschrijving> Inschrijvingen { get; set; } = new List<Inschrijving>();
    }
}
