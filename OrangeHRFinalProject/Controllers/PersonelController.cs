using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrangeHRFinalProject.Controllers
{
    public class PersonelController: Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
