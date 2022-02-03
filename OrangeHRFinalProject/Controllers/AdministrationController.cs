using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using OrangeHRFinalProject.BLL.ServiceOperations.Common;
using OrangeHRFinalProject.BLL.ServiceOperations.Interfaces;
using OrangeHRFinalProject.ViewModels.Combined.AdministrationViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrangeHRFinalProject.Controllers
{
    public class AdministrationController:Controller
    {
        private readonly IUserServiceOperations userService;
        private readonly ICompanyService companyService;
        private readonly IHolidayService holidayService;

        public AdministrationController(IUserServiceOperations userService,ICompanyService companyService,IHolidayService holidayService)
        {
            this.userService = userService;
            this.companyService = companyService;
            this.holidayService = holidayService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var managers = await userService.UserRoleListByRoleName(CoreDefinitions.RoleManager);
            var personels = await userService.UserRoleListByRoleName(CoreDefinitions.RoleEmployee);
            var companies = await companyService.GetAllActiveCompanies();
            var companyMembership = await companyService.GetAllActiveCompanies();
            var holidayList = await holidayService.GetAllByOrder();

            AdminMainVM vm = new AdminMainVM
            {
                NumberOfManagers=managers.Count,
                NumberOfPersonels=personels.Count,
                NumberOfCompanies=companies.Count
            };

            ViewBag.CompanyList = companyMembership;
            ViewBag.HolidayList = holidayList;

            return Json(vm);
        }


    }
}
