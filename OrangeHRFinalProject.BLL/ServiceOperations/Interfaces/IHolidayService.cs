using OrangeHRFinalProject.Entities.Concretes;
using OrangeHRFinalProject.ViewModels.HolidayViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRFinalProject.BLL.ServiceOperations.Interfaces
{
    public interface IHolidayService:IServiceOperations<Holiday,HolidayDetailsVM,HolidayCreateVM,HolidayUpdateVM>
    {
    }
}
