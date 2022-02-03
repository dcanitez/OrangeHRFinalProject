using AutoMapper;
using OrangeHRFinalProject.BLL.ServiceOperations.Common;
using OrangeHRFinalProject.BLL.ServiceOperations.Interfaces;
using OrangeHRFinalProject.DAL.Repositories.Interfaces;
using OrangeHRFinalProject.Entities.Concretes;
using OrangeHRFinalProject.ViewModels.Commons.CountryViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRFinalProject.BLL.ServiceOperations.Concretes
{
    public class CountryService : ServiceBase<Country, ICountryRepository, CountryDetailsVM, CountryCreateVM, CountryUpdateVM>,ICountryService
    {
        private readonly ICountryRepository service;
        private readonly IMapper mapper;

        public CountryService(ICountryRepository service, IMapper mapper) : base(service, mapper)
        {
            this.service = service;
            this.mapper = mapper;
        }

        public async Task<Country> FindByName(string name)
        {
            var country = await service.GetAsync(a => a.Name.ToLower() == name.ToLower()) as Country;
            return country;
        }

        public async Task<List<CountryDetailsVM>> GetCountriesWithCityList()
        {
            var result = await service.GetAsync(null, null, true, a => a.Cities);
            var list = mapper.Map<List<CountryDetailsVM>>(result);
            return list;
        }
    }
}
