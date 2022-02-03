using OrangeHRFinalProject.BLL.ServiceOperations.Common;
using OrangeHRFinalProject.Entities.Concretes;
using OrangeHRFinalProject.ViewModels.Commons.DepartmentViewModels;

namespace OrangeHRFinalProject.BLL.ServiceOperations.Interfaces
{
    public interface IDepartmentService : IServiceOperations<Department, DepartmentDetailsVM, DepartmentCreateVM, DepartmentUpdateVM>
    {

    }

}
