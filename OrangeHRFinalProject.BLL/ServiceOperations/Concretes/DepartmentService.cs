using AutoMapper;
using OrangeHRFinalProject.BLL.ServiceOperations.Common;
using OrangeHRFinalProject.BLL.ServiceOperations.Interfaces;
using OrangeHRFinalProject.DAL.Repositories.Interfaces;
using OrangeHRFinalProject.Entities.Concretes;
using OrangeHRFinalProject.ViewModels.Combined.ManagerViewModels.MainPageVM;
using OrangeHRFinalProject.ViewModels.Commons.DepartmentViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRFinalProject.BLL.ServiceOperations.Concretes
{
    public class DepartmentService : ServiceBase<Department, IDepartmentRepository, DepartmentDetailsVM, DepartmentCreateVM, DepartmentUpdateVM>,IDepartmentService
    {
        private readonly IDepartmentRepository service;
        private readonly IMapper mapper;

        public DepartmentService(IDepartmentRepository service, IMapper mapper) : base(service, mapper)
        {
            this.service = service;
            this.mapper = mapper;
        }

        public async Task<Department> FindByName(string name)
        {
            var result = await service.GetAsync(a => a.Description.ToLower() == name.Trim().ToLower()) as Department;
            return result;
        }

        public async Task<List<EmployeeDepartmentDetailsVM>> GetDepartmentCounts()
        {
            var result = await service.GetAllAsync();
            var list = mapper.Map<List<EmployeeDepartmentDetailsVM>>(result);
            return list;
        }
    }
}
