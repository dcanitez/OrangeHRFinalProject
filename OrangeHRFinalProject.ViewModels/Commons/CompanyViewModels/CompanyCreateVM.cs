using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRFinalProject.ViewModels.Commons.CompanyViewModels
{
    public class CompanyCreateVM
    {
        //[Required(ErrorMessage = "{0} girilmesi zorunludur.")]
        [Display(Name = "Sektör", Prompt =  "Sektör")]
        [MaxLength(50)]
        public string Sector { get; set; }

        //[Required(ErrorMessage = "{0} girilmesi zorunludur.")]
        [Display(Name = "Şirket Adı", Prompt = "Şirket Adı")]
        [MaxLength(150)]
        public string CompanyName { get; set; }

        [Display(Name = "Çalışan Sayısı", Prompt = "Çalışan Sayısı")]
        public int NumberofEmployee { get; set; } = 1;
        
    }
}
