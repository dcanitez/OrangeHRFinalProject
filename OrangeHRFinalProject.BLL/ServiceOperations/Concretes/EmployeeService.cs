using AutoMapper;
using OrangeHRFinalProject.BLL.ServiceOperations.Common;
using OrangeHRFinalProject.BLL.ServiceOperations.Interfaces;
using OrangeHRFinalProject.DAL.Repositories.Interfaces;
using OrangeHRFinalProject.Entities.Concretes;
using OrangeHRFinalProject.ViewModels.EmployeeViewModels;
using OrangeHRFinalProject.ViewModels.ManagerViewModels.MainPageVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRFinalProject.BLL.ServiceOperations.Concretes
{
    public class EmployeeService : ServiceBase<Employee, IEmployeeRepository, EmployeeDetailsVM, EmployeeCreateVM, EmployeeUpdateVM>, IEmployeeService
    {
        private readonly IEmployeeRepository service;
        private readonly IMapper mapper;

        public EmployeeService(IEmployeeRepository service, IMapper mapper) : base(service, mapper)
        {
            this.service = service;
            this.mapper = mapper;
        }

        public async Task<Employee> GetByEmail(string email)
        {
            var employees = await service.GetAllAsync();
            Employee employee = employees.SingleOrDefault(m => m.CorporateEmail == email);
            return employee;
        }

        public async Task<List<BirthDayVM>> GethBirthDayList()
        {
            var employees = await service.GetAsync(null, a => a.OrderBy(a => a.BirthDay),true,null);
            var list=mapper.Map<List<BirthDayVM>>(employees);
            return list;
        }
    }
}
