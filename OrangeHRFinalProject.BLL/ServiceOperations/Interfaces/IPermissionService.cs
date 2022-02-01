using OrangeHRFinalProject.Entities.Concretes;
using OrangeHRFinalProject.ViewModels.ManagerViewModels.MainPageVM;
using OrangeHRFinalProject.ViewModels.PermissionViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRFinalProject.BLL.ServiceOperations.Interfaces
{
    public interface IPermissionService:IServiceOperations<Permission,PermissionDetailsVM,PermissionCreateVM,PermissionUpdateVM>
    {
        Task<List<PermissionVM>> GetListWithEmployeeDetails();
    }
}
