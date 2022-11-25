using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace NordicDoor.Models
{
    public class ForslagModel
    {
        [Key]
        public int ForslagID { get; set; }
        [Required]
        [ValidateNever]
        public int AnsattID { get; set; }
        [Required]
        [ValidateNever]
        public string Tittel { get; set; }
        [DisplayName("Nytt Forslag")]
        [Required]
        [ValidateNever]
        public string NyttForslag { get; set; }

        public string Årsak { get; set; }
        [ValidateNever]
        public string Mål { get; set; }
        [ValidateNever]
        public string Løsning { get; set; }
        [DisplayName("Dato Registrert")]
        [Required]
        [ValidateNever]
        public DateTime DatoRegistrert { get; set; } = DateTime.Now;
        public DateTime Frist { get; set; }
        [ValidateNever]
        public string ImageUrl { get; set; }
        [ValidateNever]
        public int Team { get; set; }
        [ValidateNever]
        public string Ansavarlig { get; set; }  

    }
}

