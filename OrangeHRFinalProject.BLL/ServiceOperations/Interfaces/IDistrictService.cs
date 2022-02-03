using OrangeHRFinalProject.BLL.ServiceOperations.Common;
using OrangeHRFinalProject.Entities.Concretes;
using OrangeHRFinalProject.ViewModels.Commons.DistrictViewModels;

namespace OrangeHRFinalProject.BLL.ServiceOperations.Interfaces
{
    public interface IDistrictService : IServiceOperations<District, DistrictDetailsVM, DistrictCreateVM, DistrictUpdateVM>
    {

    }
}
