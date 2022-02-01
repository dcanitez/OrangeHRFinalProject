using AutoMapper;
using OrangeHRFinalProject.BLL.ServiceOperations.Common;
using OrangeHRFinalProject.BLL.ServiceOperations.Interfaces;
using OrangeHRFinalProject.DAL.Repositories.Interfaces;
using OrangeHRFinalProject.Entities.Concretes;
using OrangeHRFinalProject.ViewModels.AccountViewModels.RegisterVM;
using OrangeHRFinalProject.ViewModels.CompanyViewModels;
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
        public CompanyService(ICompanyRepository service, IMapper mapper, IEmployeeService employeeService) : base(service, mapper)
        {
            this.service = service;
            this.mapper = mapper;
            this.employeeService = employeeService;

        }

        public async Task<Company> GetByName(string companyName)
        {
            var companies = await service.GetAllAsync();
            return companies.SingleOrDefault(m => m.Name.ToLower() == companyName.ToLower());
        }

        public async Task<bool> Add(UserRegisterVM model)
        {
            Employee result = await employeeService.Add(model.Employee);
            if (result!=null)
            {              
                Company entity = mapper.Map<Company>(model.Company);
                entity.Employees.Add(result);
                var company = await service.AddAsync(entity);
                return company != null;
            }
            else
                return false;
        }
    }
}
