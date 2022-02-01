using AutoMapper;
using OrangeHRFinalProject.BLL.ServiceOperations.Interfaces;
using OrangeHRFinalProject.ViewModels.HolidayViewModels;
using OrangeHRFinalProject.ViewModels.ManagerViewModels.MainPageVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRFinalProject.BLL.ServiceOperations.Concretes
{
    public class ManagerPanelService:IManagerPanelService
    {
        private readonly IEmployeeService employeeService;
        private readonly IHolidayService holidayService;
        private readonly IPermissionService permissionService;
        private readonly IMapper mapper;

        public ManagerPanelService(IEmployeeService employeeService, IHolidayService holidayService,IPermissionService permissionService,IMapper mapper)
        {
            this.employeeService = employeeService;
            this.holidayService = holidayService;
            this.permissionService = permissionService;
            this.mapper = mapper;
        }

        public async Task<ManagerMainVM> GetMainDetails()
        {
            ManagerMainVM vm = new ManagerMainVM();
            vm.BirthDayList= await employeeService.GethBirthDayList();
            vm.HolidayList = await holidayService.GetAll() as List<HolidayDetailsVM>;
            vm.PermissionList = await permissionService.GetListWithEmployeeDetails();
            return vm;
        }
    }
}
