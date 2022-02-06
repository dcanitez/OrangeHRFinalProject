using System.ComponentModel.DataAnnotations;

namespace OrangeHRFinalProject.ViewModels.Commons.EmployeeViewModels
{
    public class EmployeeCreateVM
    {
        [MaxLength(60)]
        [Display(Name = "Ad", Prompt = "Ad")]
        public string FirstName { get; set; }

        [MaxLength(70)]
        [Display(Name = "Soyad", Prompt = "Soyad")]
        public string LastName { get; set; }

        [StringLength(11, MinimumLength = 11, ErrorMessage = "Lütfen {0} bilgisini başında 0 olarak {1} karakter olarak yazınız.")]
        [Display(Name = "Şirket Telefonunuz", Prompt = "Şirket Telefonunuz")]
        [DataType(DataType.PhoneNumber)]
        public string CorporatePhoneNumber { get; set; }

        [Required(ErrorMessage = "{0} girilmesi zorunludur.")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Şirket E-posta Adresi", Prompt = "Şirket E-postanız")]
        //[RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$", ErrorMessage = "Mail adresinizi uygun formatta giriniz.")]
        public string CorporateEMail { get; set; }

        [Required(ErrorMessage = "{0} girilmesi zorunludur.")]
        [DataType(DataType.Password)]
        [Display(Name = "Parola", Prompt = "Parola")]
        public string Password { get; set; }

        [Display(Name = "Kullanıcı Sözleşmesi" ,Prompt = "Kullanıcı Sözleşmesi")]
        public bool IsDataProtectionRead { get; set; }

    }
}
