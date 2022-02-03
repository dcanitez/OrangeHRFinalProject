using OrangeHRFinalProject.BLL.ServiceOperations.Common;
using OrangeHRFinalProject.Entities.Concretes;
using OrangeHRFinalProject.ViewModels.Commons.CountryViewModels;


namespace OrangeHRFinalProject.BLL.ServiceOperations.Interfaces
{
    public interface ICountryService : IServiceOperations<Country, CountryDetailsVM, CountryCreateVM, CountryUpdateVM>
    {

    }
}
