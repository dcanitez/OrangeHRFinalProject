using Microsoft.AspNetCore.Identity;
using OrangeHRFinalProject.BLL.ServiceOperations.Common;
using OrangeHRFinalProject.BLL.ServiceOperations.Interfaces;
using OrangeHRFinalProject.Entities.Authentication;
using OrangeHRFinalProject.ViewModels.AdministrationViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRFinalProject.BLL.ServiceOperations.Concretes
{
    public class AdministrationService: IAdministrationService
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly RoleManager<ApplicationRole> roleManager;
        private readonly ICompanyService companyService;
        private readonly IHolidayService holidayService;

        public AdministrationService(UserManager<ApplicationUser> userManager,RoleManager<ApplicationRole> roleManager, ICompanyService companyService,IHolidayService holidayService)
        {
            this.userManager = userManager;
            this.roleManager = roleManager;
            this.companyService = companyService;
            this.holidayService = holidayService;
        }

        public async Task<AdminMainVM> GetMainPageInformation()
        {
            var ManagerRoles = await UserRoleListByRoleName(CoreDefinitions.RoleManager);
            var PersonelRoles = await UserRoleListByRoleName(CoreDefinitions.RoleEmployee);

            AdminMainVM vm = new AdminMainVM
            {
                NumberOfManagers = ManagerRoles.Count,
                NumberOfPersonels = PersonelRoles.Count
            };
            vm.Holidays.AddRange(await holidayService.GetAll());
            vm.Companies.AddRange(await companyService.GetAll());

            return vm;
        }
        private async Task<List<ApplicationUser>> UserRoleListByRoleName(string roleName)
        {
            List<ApplicationUser> userList = new List<ApplicationUser>();

            foreach (var item in userManager.Users.Where(u => !u.UserName.Contains("admin")).ToList())
            {
                if (await userManager.IsInRoleAsync(item, roleName))
                {
                    userList.Add(item);
                }
            }
            return userList;
        }



         
    }
}
