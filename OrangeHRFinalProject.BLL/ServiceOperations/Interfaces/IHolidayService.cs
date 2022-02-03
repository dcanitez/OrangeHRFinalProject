using OrangeHRFinalProject.BLL.ServiceOperations.Common;
using OrangeHRFinalProject.Entities.Concretes;
using OrangeHRFinalProject.ViewModels.Commons.HolidayViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OrangeHRFinalProject.BLL.ServiceOperations.Interfaces
{
    public interface IHolidayService : IServiceOperations<Holiday, HolidayDetailsVM, HolidayCreateVM, HolidayUpdateVM>
    {
        Task<List<HolidayDetailsVM>> GetAllByOrder();
    }
}
