using OrangeHRFinalProject.BLL.ServiceOperations.Common;
using OrangeHRFinalProject.Entities.Concretes;
using OrangeHRFinalProject.ViewModels.Combined.ManagerViewModels.MainPageVM;
using OrangeHRFinalProject.ViewModels.Commons.DepartmentViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OrangeHRFinalProject.BLL.ServiceOperations.Interfaces
{
    public interface IDepartmentService : IServiceOperations<Department, DepartmentDetailsVM, DepartmentCreateVM, DepartmentUpdateVM>
    {
        Task<List<EmployeeDepartmentDetailsVM>> GetDepartmentCounts();
        Task<Department> FindByName(string name);
    }

}
