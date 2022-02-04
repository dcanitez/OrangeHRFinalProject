using AutoMapper;
using OrangeHRFinalProject.BLL.ServiceOperations.Common;
using OrangeHRFinalProject.BLL.ServiceOperations.Interfaces;
using OrangeHRFinalProject.DAL.Repositories.Interfaces;
using OrangeHRFinalProject.Entities.Concretes;
using OrangeHRFinalProject.ViewModels.Commons.ShiftViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRFinalProject.BLL.ServiceOperations.Concretes
{
    public class ShiftService : ServiceBase<Shift, IShiftRepository, ShiftDetailsVM, ShiftCreateVM, ShiftUpdateVM>, IShiftService
    {
        private readonly IShiftRepository service;
        private readonly IMapper mapper;

        public ShiftService(IShiftRepository service, IMapper mapper) : base(service, mapper)
        {
            this.service = service;
            this.mapper = mapper;
        }
    }
}
