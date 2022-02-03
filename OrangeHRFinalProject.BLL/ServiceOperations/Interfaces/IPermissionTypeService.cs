using OrangeHRFinalProject.BLL.ServiceOperations.Common;
using OrangeHRFinalProject.Entities.Concretes;
using OrangeHRFinalProject.ViewModels.Commons.PermissionTypeViewModels;

namespace OrangeHRFinalProject.BLL.ServiceOperations.Interfaces
{
    public interface IPermissionTypeService : IServiceOperations<PermissionType, PermissionTypeDetailsVM, PermissionTypeCreateVM, PermissionTypeUpdateVM>
    {

    }
}
