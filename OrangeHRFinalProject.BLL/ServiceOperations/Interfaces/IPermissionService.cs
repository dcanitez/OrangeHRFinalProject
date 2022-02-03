using OrangeHRFinalProject.BLL.ServiceOperations.Common;
using OrangeHRFinalProject.Entities.Concretes;
using OrangeHRFinalProject.ViewModels.Combined.ManagerViewModels.MainPageVM;
using OrangeHRFinalProject.ViewModels.Commons.PermissionViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OrangeHRFinalProject.BLL.ServiceOperations.Interfaces
{
    public interface IPermissionService : IServiceOperations<Permission, PermissionDetailsVM, PermissionCreateVM, PermissionUpdateVM>
    {
        Task<List<PermissionVM>> GetPermissionList();
    }
}
