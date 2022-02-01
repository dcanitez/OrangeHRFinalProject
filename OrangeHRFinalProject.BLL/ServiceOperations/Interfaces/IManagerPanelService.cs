using OrangeHRFinalProject.ViewModels.ManagerViewModels.MainPageVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRFinalProject.BLL.ServiceOperations.Interfaces
{
    public interface IManagerPanelService
    {
        Task<ManagerMainVM> GetMainDetails();
    }
}
