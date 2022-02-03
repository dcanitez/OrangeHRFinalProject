using OrangeHRFinalProject.BLL.ServiceOperations.Common;
using OrangeHRFinalProject.Entities.Concretes;
using OrangeHRFinalProject.ViewModels.Combined.AdministrationViewModels;
using OrangeHRFinalProject.ViewModels.Commons.CompanyViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRFinalProject.BLL.ServiceOperations.Interfaces
{
    public interface ICompanyService : IServiceOperations<Company, CompanyDetailsVM, CompanyCreateVM, CompanyUpdateVM>
    {
        Task<List<CompanyDetailsVM>> GetAllActiveCompanies();
        Task<List<CompanyMembershipDetailsVM>> GetMembershipDetailList();
        Task<Company> GetActiveCompanById(int id);
    }

}
