using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRFinalProject.ViewModels.AccountViewModels.LoginVM
{
    public class ManagerLoginVM
    {
        [Required]
        public string FieldName { get; set; }

        [Required(ErrorMessage = "{0} girilmesi zorunludur.")]
        [DataType(DataType.Password)]
        [Display(Name = "Parola", Prompt = "Parola")]
        public string Password { get; set; }
    }
}
