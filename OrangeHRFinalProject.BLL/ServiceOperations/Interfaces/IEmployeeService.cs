using OrangeHRFinalProject.Entities.Concretes;
using OrangeHRFinalProject.ViewModels.EmployeeViewModels;
using OrangeHRFinalProject.ViewModels.ManagerViewModels.MainPageVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRFinalProject.BLL.ServiceOperations.Interfaces
{
    public interface IEmployeeService:IServiceOperations<Employee,EmployeeDetailsVM,EmployeeCreateVM,EmployeeUpdateVM>
    {
        Task<Employee> GetByEmail(string email);
        Task<List<BirthDayVM>> GethBirthDayList();
    }
}
