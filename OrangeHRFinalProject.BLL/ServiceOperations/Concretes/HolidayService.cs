using AutoMapper;
using OrangeHRFinalProject.BLL.ServiceOperations.Common;
using OrangeHRFinalProject.BLL.ServiceOperations.Interfaces;
using OrangeHRFinalProject.DAL.Repositories.Interfaces;
using OrangeHRFinalProject.Entities.Concretes;
using OrangeHRFinalProject.ViewModels.Commons.HolidayViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRFinalProject.BLL.ServiceOperations.Concretes
{
    public class HolidayService : ServiceBase<Holiday, IHolidayRepository, HolidayDetailsVM, HolidayCreateVM, HolidayUpdateVM>,IHolidayService
    {
        private readonly IHolidayRepository service;
        private readonly IMapper mapper;

        public HolidayService(IHolidayRepository service, IMapper mapper) : base(service, mapper)
        {
            this.service = service;
            this.mapper = mapper;
        }

        public async Task<List<HolidayDetailsVM>> GetAllByOrder()
        {
            var result = await service.GetAsync(a => a.StartDate > DateTime.Now, a => a.OrderBy(a => a.StartDate), true, null);
            var list = mapper.Map<List<HolidayDetailsVM>>(result);
            return list;
        }
    }
}
