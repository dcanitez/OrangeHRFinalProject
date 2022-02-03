using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OrangeHRFinalProject.BLL.ServiceOperations.Interfaces;
using OrangeHRFinalProject.Entities.Authentication;
using OrangeHRFinalProject.ViewModels.Commons.PermissionViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrangeHRFinalProject.Controllers
{
    public class PersonelController: Controller
    {
        
        private readonly IPermissionService permissionService;
        private readonly IPermissionTypeService permissionTypeService;

        public PersonelController(IPermissionService permissionService,IPermissionTypeService permissionTypeService)
        {            
            this.permissionService = permissionService;
            this.permissionTypeService = permissionTypeService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> CreatePermission()
        {
            var list = await permissionTypeService.GetAll();
            return View(list);
        }
        [HttpPost]
        public async Task<IActionResult> CreatePermission(int id,PermissionCreateVM model)
        {            
            //TODO: ID bir employeeId bilgisini userManager ile yönetmek lazım!
            if (ModelState.IsValid)
            {
                model.EmployeeId = id;
                var result = await permissionService.Add(model);
                if (result is not null)
                {
                    //bir mesaj verebiliriz belki* izin oluşturuldu bravo diye
                    return View();
                }
                ModelState.AddModelError(string.Empty, "İzin talebiniz oluşturulamadı");
            }            
            return View(model);
        }
    }
}
