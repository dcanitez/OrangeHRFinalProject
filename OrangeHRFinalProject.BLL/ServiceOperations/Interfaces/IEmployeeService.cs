using OrangeHRFinalProject.BLL.ServiceOperations.Common;
using OrangeHRFinalProject.Entities.Concretes;
using OrangeHRFinalProject.ViewModels.Combined.ManagerViewModels.MainPageVM;
using OrangeHRFinalProject.ViewModels.Commons.EmployeeViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OrangeHRFinalProject.BLL.ServiceOperations.Interfaces
{
    public interface IEmployeeService : IServiceOperations<Employee, EmployeeDetailsVM, EmployeeCreateVM, EmployeeUpdateVM>
    {
        Task<Employee> GetByCorporateEmail(string email);
        Task<List<BirthDayVM>> GetBirthdayList();
    }
}
