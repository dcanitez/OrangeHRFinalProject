using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRFinalProject.ViewModels.Combined.AccountViewModels.LoginVM
{
    public class EmployeeLoginVM
    {
        [Required(ErrorMessage = "{0} girilmesi zorunludur.")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Şirket E-posta Adresi", Prompt = "Şirket E-postanız")]
        //[RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$", ErrorMessage = "Mail adresinizi uygun formatta giriniz.")]
        public string CorporeateEMail { get; set; }

        [Required(ErrorMessage = "{0} girilmesi zorunludur.")]
        [DataType(DataType.Password)]
        [Display(Name = "Parola", Prompt = "Parola")]
        public string Password { get; set; }
    }
}
