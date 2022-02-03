using AutoMapper;
using OrangeHRFinalProject.BLL.ServiceOperations.Common;
using OrangeHRFinalProject.BLL.ServiceOperations.Interfaces;
using OrangeHRFinalProject.DAL.Repositories.Interfaces;
using OrangeHRFinalProject.Entities.Concretes;
using OrangeHRFinalProject.ViewModels.Commons.PermissionTypeViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRFinalProject.BLL.ServiceOperations.Concretes
{
    public class PermissionTypeService : ServiceBase<PermissionType, IPermissionTypeRepository, PermissionTypeDetailsVM, PermissionTypeCreateVM, PermissionTypeUpdateVM>,IPermissionTypeService
    {
        private readonly IPermissionTypeRepository service;
        private readonly IMapper mapper;

        public PermissionTypeService(IPermissionTypeRepository service, IMapper mapper) : base(service, mapper)
        {
            this.service = service;
            this.mapper = mapper;
        }
    }
}
