using Microsoft.AspNetCore.Mvc;
using OrangeHRFinalProject.BLL.ServiceOperations.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrangeHRFinalProject.Controllers
{
    public class ManagerController : Controller
    {
        private readonly IManagerPanelService managerPanelService;

        public ManagerController(IManagerPanelService managerPanelService)
        {
            this.managerPanelService = managerPanelService;
        }
        public async Task<IActionResult> Index()
        {
            var list = await managerPanelService.GetMainDetails();
            return View(list);
        }
    }
}
