using AutoMapper;
using OrangeHRFinalProject.BLL.ServiceOperations.Common;
using OrangeHRFinalProject.BLL.ServiceOperations.Interfaces;
using OrangeHRFinalProject.DAL.Repositories.Interfaces;
using OrangeHRFinalProject.Entities.Concretes;
using OrangeHRFinalProject.ViewModels.Commons.CityViewModels;

namespace OrangeHRFinalProject.BLL.ServiceOperations.Concretes
{
    public class CityService : ServiceBase<City, ICityRepository, CityDetailsVM, CityCreateVM, CityUpdateVM>, ICityService
    {
        private readonly ICityRepository service;
        private readonly IMapper mapper;

        public CityService(ICityRepository service, IMapper mapper) : base(service, mapper)
        {
            this.service = service;
            this.mapper = mapper;
        }
    }
}
