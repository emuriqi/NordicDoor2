using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace NordicDoorWeb.Models
{
    public class AnsattModel
    {
        public int Id { get; set; }
   
        public string Fornavn { get; set; }
        [ValidateNever]
        public string Etternavn { get; set; }
     
        public string Rolle { get; set; }
        public int Team { get; set;}
    }
}
