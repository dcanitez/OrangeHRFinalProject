using Microsoft.AspNetCore.Mvc;
using OrangeHRFinalProject.BLL.ServiceOperations.Interfaces;
using OrangeHRFinalProject.ViewModels.Combined.ManagerViewModels.MainPageVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrangeHRFinalProject.Controllers
{
    public class ManagerController : Controller
    {
        private readonly IEmployeeService employeeService;
        private readonly IHolidayService holidayService;
        private readonly IPermissionService permissionService;

        public ManagerController(IEmployeeService employeeService, IHolidayService holidayService, IPermissionService permissionService)
        {
            this.employeeService = employeeService;
            this.holidayService = holidayService;
            this.permissionService = permissionService;
        }
        public async Task<IActionResult> Index()
        {
            var birthdayList = await employeeService.GetBirthdayList();
            var permissionList = await permissionService.GetPermissionList();
            var holidayList = await holidayService.GetAllByOrder();

            ViewBag.BirthDayList = birthdayList;
            ViewBag.PermissionList = permissionList;
            ViewBag.HolidayList = holidayList;

            ManagerMainVM vm = new ManagerMainVM
            {
                
            };

            return Json(vm);
        }
    }
}
