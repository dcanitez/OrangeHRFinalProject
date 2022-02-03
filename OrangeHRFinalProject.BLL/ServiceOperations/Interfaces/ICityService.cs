using OrangeHRFinalProject.BLL.ServiceOperations.Common;
using OrangeHRFinalProject.Entities.Concretes;
using OrangeHRFinalProject.ViewModels.Commons.CityViewModels;

namespace OrangeHRFinalProject.BLL.ServiceOperations.Interfaces
{
    public interface ICityService : IServiceOperations<City, CityDetailsVM, CityCreateVM, CityUpdateVM>
    {

    }
}
