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

        [Required(ErrorMessage = "Titel kan niet leeg zijn!")]
        public required string Titel { get; set; }

        [Required(ErrorMessage = "Studiepunten zijn verplicht!")]
        public required int Studiepunten { get; set; }

        [Required(ErrorMessage = "Kies een docent.")]
        public required int DocentId { get; set; }
        public required Docent Docent { get; set; }

        public List<Inschrijving> Inschrijvingen { get; set; } = new List<Inschrijving>();

    }
}
