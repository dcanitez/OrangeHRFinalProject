using AutoMapper;
using OrangeHRFinalProject.BLL.ServiceOperations.Common;
using OrangeHRFinalProject.BLL.ServiceOperations.Interfaces;
using OrangeHRFinalProject.DAL.Repositories.Interfaces;
using OrangeHRFinalProject.Entities.Concretes;
using OrangeHRFinalProject.ViewModels.Combined.AccountViewModels.RegisterVM;
using OrangeHRFinalProject.ViewModels.Combined.AdministrationViewModels;
using OrangeHRFinalProject.ViewModels.Commons.CompanyViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRFinalProject.BLL.ServiceOperations.Concretes
{
    public class CompanyService : ServiceBase<Company, ICompanyRepository, CompanyDetailsVM, CompanyCreateVM, CompanyUpdateVM>, ICompanyService
    {
        private readonly ICompanyRepository service;
        private readonly IMapper mapper;
        private readonly IEmployeeService employeeService;

        public CompanyService(ICompanyRepository service, IMapper mapper,IEmployeeService employeeService) : base(service, mapper)
        {
            this.service = service;
            this.mapper = mapper;
            this.employeeService = employeeService;
        }

        public async Task<List<CompanyDetailsVM>> GetAllActiveCompanies()
        {
            var result = await service.GetAsync(a => a.IsActive == true);
            List<CompanyDetailsVM> list = mapper.Map<List<CompanyDetailsVM>>(result);
            return list;
        }

        public async Task<List<CompanyMembershipDetailsVM>> GetMembershipDetailList()
        {
            var result = await service.GetAsync(c => c.IsActive, c => c.OrderByDescending(c => c.MembershipEndDate), true, null);
            var list = mapper.Map<List<CompanyMembershipDetailsVM>>(result);
            return list;
        }

    }
}
