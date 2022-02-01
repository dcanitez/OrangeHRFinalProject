using Microsoft.AspNetCore.Mvc;
using OrangeHRFinalProject.BLL.ServiceOperations.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrangeHRFinalProject.Controllers
{
    public class AdministrationController:Controller
    {
        
        private readonly IAdministrationService administrationService;
        public AdministrationController(IAdministrationService administrationService)
        {
            this.administrationService = administrationService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var model=await administrationService.GetMainPageInformation();
            return View(model);
        }


    }
}
