using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OrangeHRFinalProject.BLL.ServiceOperations.Interfaces;
using OrangeHRFinalProject.Entities.Authentication;
using OrangeHRFinalProject.ViewModels.PermissionViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrangeHRFinalProject.Controllers
{
    public class PersonelController: Controller
    {
        private readonly IPermissionService permissionService;       

        public PersonelController(IPermissionService permissionService)
        {
            this.permissionService = permissionService;            
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult CreatePermission()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreatePermission(int id,PermissionCreateVM model)
        {            
            //TODO: ID bir employeeId bilgisini userManager ile yönetmek lazım!
            if (ModelState.IsValid)
            {
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
