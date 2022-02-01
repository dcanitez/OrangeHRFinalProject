using OrangeHRFinalProject.ViewModels.AdministrationViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRFinalProject.BLL.ServiceOperations.Interfaces
{
    public interface IAdministrationService
    {
        Task<AdminMainVM> GetMainPageInformation();
    }
}
