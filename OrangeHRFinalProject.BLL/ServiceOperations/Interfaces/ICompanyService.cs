using OrangeHRFinalProject.Entities.Concretes;
using OrangeHRFinalProject.ViewModels.AccountViewModels.RegisterVM;
using OrangeHRFinalProject.ViewModels.CompanyViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRFinalProject.BLL.ServiceOperations.Interfaces
{
    public interface ICompanyService: IServiceOperations<Company,CompanyDetailsVM, CompanyCreateVM, CompanyUpdateVM>
    {
        Task<Company> GetByName(string name);
        Task<bool> Add(UserRegisterVM model);
    }
}
