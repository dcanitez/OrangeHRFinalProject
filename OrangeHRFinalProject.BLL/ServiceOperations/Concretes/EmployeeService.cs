using AutoMapper;
using OrangeHRFinalProject.BLL.ServiceOperations.Common;
using OrangeHRFinalProject.BLL.ServiceOperations.Interfaces;
using OrangeHRFinalProject.DAL.Repositories.Interfaces;
using OrangeHRFinalProject.Entities.Concretes;
using OrangeHRFinalProject.ViewModels.Combined.ManagerViewModels.MainPageVM;
using OrangeHRFinalProject.ViewModels.Commons.EmployeeViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRFinalProject.BLL.ServiceOperations.Concretes
{
    public class EmployeeService : ServiceBase<Employee, IEmployeeRepository, EmployeeDetailsVM, EmployeeCreateVM, EmployeeUpdateVM>,IEmployeeService
    {
        private readonly IEmployeeRepository service;
        private readonly IMapper mapper;

        public EmployeeService(IEmployeeRepository service, IMapper mapper) : base(service, mapper)
        {
            this.service = service;
            this.mapper = mapper;
        }

        public async Task<Employee> GetByCorporateEmail(string email)
        {
            var employee = await service.GetAsync(m => m.CorporateEmail.ToLower() == email.ToLower()) as Employee;
            return employee;
        }

        public async Task<List<BirthDayVM>> GetBirthdayList()
        {
            var employees = await service.GetAsync(a => a.IsActive == true && a.BirthDay.Value > DateTime.Now, a => a.OrderByDescending(a => a.BirthDay), true, null);
            var list = mapper.Map<List<BirthDayVM>>(employees);
            return list;
        }
    }
}
