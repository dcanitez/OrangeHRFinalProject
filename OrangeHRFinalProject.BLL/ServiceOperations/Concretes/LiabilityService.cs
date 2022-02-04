using AutoMapper;
using OrangeHRFinalProject.BLL.ServiceOperations.Common;
using OrangeHRFinalProject.BLL.ServiceOperations.Interfaces;
using OrangeHRFinalProject.DAL.Repositories.Interfaces;
using OrangeHRFinalProject.Entities.Concretes;
using OrangeHRFinalProject.ViewModels.Commons.LiabilityViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRFinalProject.BLL.ServiceOperations.Concretes
{
    public class LiabilityService : ServiceBase<Liability, ILiabilityRepository, LiabilityDetailsVM, LiabilityCreateVM, LiabilityUpdateVM>, ILiabilityService
    {
        private readonly ILiabilityRepository service;
        private readonly IMapper mapper;

        public LiabilityService(ILiabilityRepository service, IMapper mapper) : base(service, mapper)
        {
            this.service = service;
            this.mapper = mapper;
        }
    }
}
