using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NordicDoor.Models
{
    public class ForslagModel
    {
        [Key]
        public int ForslagID { get; set; }
        [Required]
        public int AnsattID { get; set; }
        [Required]
        public string Tittel { get; set; }
        [DisplayName("Nytt Forslag")]
        [Required]
        public string NyttForslag { get; set; }

        public string Årsak { get; set; }

        public string Mål { get; set; }

        public string Løsning { get; set; }
        [DisplayName("Dato Registrert")]
        [Required]
        public DateTime DatoRegistrert { get; set; } = DateTime.Now;
        public DateTime Frist { get; set; }
        public string ImageUrl { get; set; }
        public int Team { get; set; }
        public string Ansavarlig { get; set; }  

    }
}

