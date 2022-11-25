using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NordicDoor.Models.ViewModels
{
    public class ForslagVM
    {
        public ForslagModel forslags { get; set; }
        [ValidateNever]
        public  IEnumerable<SelectListItem> AnsattList { get; set; }
         
    }
}
