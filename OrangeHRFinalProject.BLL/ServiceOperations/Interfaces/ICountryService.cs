using OrangeHRFinalProject.BLL.ServiceOperations.Common;
using OrangeHRFinalProject.Entities.Concretes;
using OrangeHRFinalProject.ViewModels.Commons.CountryViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OrangeHRFinalProject.BLL.ServiceOperations.Interfaces
{
    public interface ICountryService : IServiceOperations<Country, CountryDetailsVM, CountryCreateVM, CountryUpdateVM>
    {
        Task<Country> FindByName(string name);
        Task<List<CountryDetailsVM>> GetCountriesWithCityList();
    }
}
