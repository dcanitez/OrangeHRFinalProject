using AutoMapper;
using OrangeHRFinalProject.BLL.ServiceOperations.Common;
using OrangeHRFinalProject.BLL.ServiceOperations.Interfaces;
using OrangeHRFinalProject.DAL.Repositories.Interfaces;
using OrangeHRFinalProject.Entities.Concretes;
using OrangeHRFinalProject.ViewModels.Combined.ManagerViewModels.MainPageVM;
using OrangeHRFinalProject.ViewModels.Commons.PermissionViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRFinalProject.BLL.ServiceOperations.Concretes
{
    public class PermissionService : ServiceBase<Permission, IPermissionRepository, PermissionDetailsVM, PermissionCreateVM, PermissionUpdateVM>,IPermissionService
    {
        private readonly IPermissionRepository service;
        private readonly IMapper mapper;

        public PermissionService(IPermissionRepository service, IMapper mapper) : base(service, mapper)
        {
            this.service = service;
            this.mapper = mapper;
        }

        public async Task<List<PermissionVM>> GetPermissionList()
        {
            var permissions = await service.GetAsync(a => a.IsActive == true && a.Status == Entities.Enums.Status.Approved && a.StartDate>DateTime.Now, a => a.OrderBy(a => a.StartDate), true, a => a.Employee);
            var list = mapper.Map<List<PermissionVM>>(permissions);
            return list;
        }

    }
}
