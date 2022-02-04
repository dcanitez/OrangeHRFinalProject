using Microsoft.AspNetCore.Mvc;
using OrangeHRFinalProject.BLL.ServiceOperations.Interfaces;
using OrangeHRFinalProject.ViewModels.Combined.ManagerViewModels.MainPageVM;
using OrangeHRFinalProject.ViewModels.Commons.CommentViewModels;
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
        private readonly ITitleService titleService;
        private readonly IDepartmentService departmentService;
        private readonly ICommentService commentService;
        private readonly IUserServiceOperations userService;
        private readonly ICompanyService companyService;

        public ManagerController(IEmployeeService employeeService, IHolidayService holidayService, IPermissionService permissionService, ITitleService titleService,IDepartmentService departmentService,ICommentService commentService,IUserServiceOperations userService,ICompanyService companyService)
        {
            this.employeeService = employeeService;
            this.holidayService = holidayService;
            this.permissionService = permissionService;
            this.titleService = titleService;
            this.departmentService = departmentService;
            this.commentService = commentService;
            this.userService = userService;
            this.companyService = companyService;
        }
        [HttpGet]
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
                EmployeeTitleList = await titleService.GetTitleCounts(),
                EmployeeDepartmentList = await departmentService.GetDepartmentCounts()
            };

            return Json(vm);
        }

        [HttpPost]
        public async Task<IActionResult> AddComment(int userId,CommentCreateVM model)
        {
            if (ModelState.IsValid)
            {
                var user = await userService.FindUserById(userId);
                var employee = await employeeService.GetByCorporateEmail(user.Email);
                var company = await companyService.GetActiveCompanById(employee.CompanyId.Value);
                if (employee.Comment==null && company.CommentCount==0)
                {
                    model.ManagerId = employee.Id;
                    var result = await commentService.Add(model);
                    if (result is not null)
                        ViewBag.message = "Yorumunuz başarıyla oluşturulmuştur, teşekkür ederiz.";
                    else
                        ModelState.AddModelError(string.Empty, "Yorumunuz oluşturulamadı"); 
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Yorumunuz oluşturulamadı");
                }

            }
            return View();
        }

    }
}
