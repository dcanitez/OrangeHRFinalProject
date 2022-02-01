using OrangeHRFinalProject.ViewModels.CompanyViewModels;
using OrangeHRFinalProject.ViewModels.EmployeeViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRFinalProject.ViewModels.AccountViewModels.RegisterVM
{
    public class UserRegisterVM
    {
        public UserRegisterVM()
        {
            Employee = new EmployeeCreateVM();
            Company = new CompanyCreateVM();
        }
        public EmployeeCreateVM Employee { get; set; }            
        public CompanyCreateVM Company { get; set; }
        
    }
}
