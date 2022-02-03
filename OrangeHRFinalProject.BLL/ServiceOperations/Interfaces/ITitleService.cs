using OrangeHRFinalProject.BLL.ServiceOperations.Common;
using OrangeHRFinalProject.Entities.Concretes;
using OrangeHRFinalProject.ViewModels.Combined.ManagerViewModels.MainPageVM;
using OrangeHRFinalProject.ViewModels.Commons.TitleViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OrangeHRFinalProject.BLL.ServiceOperations.Interfaces
{
    public interface ITitleService : IServiceOperations<Title, TitleDetailsVM, TitleCreateVM, TitleUpdateVM>
    {
        Task<List<EmployeeTitleDetailsVM>> GetTitleCounts();
    }
}
