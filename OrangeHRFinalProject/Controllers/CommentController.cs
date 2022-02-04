using Microsoft.AspNetCore.Mvc;
using OrangeHRFinalProject.BLL.ServiceOperations.Interfaces;
using OrangeHRFinalProject.ViewModels.Commons.CommentViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrangeHRFinalProject.Controllers
{
    public class CommentController : Controller
    {
        private readonly ICommentService commentService;

        public CommentController(ICommentService commentService)
        {
            this.commentService = commentService;
        }


        public async Task<IActionResult> Main()
        {
            //var list = await commentService.GetAllCommentDetails();
            List<CommentDetailsVM> list = new List<CommentDetailsVM>
            {
                new CommentDetailsVM
                {
                     CompanyName="Burger King",
                     CommentId=1,
                     ShortDescription="Dijitalin yeni manuel olduğu dünyada şirket ve çalışanları bir araya getirecek interaktif İK sistemine Kolay İK ile kavuştuk. DİLAYYLAYYY",
                     NumberOfEmployees=1
                }
            };

            return View(list);
            //return View();
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            //var comment = await commentService.GetByIdWithDetails(id);

            CommentDetailsVM comment = new CommentDetailsVM
            {
                CompanyName = "Burger King",
                CommentId = 1,
                ShortDescription = "Dijitalin yeni manuel olduğu dünyada şirket ve çalışanları bir araya getirecek interaktif İK sistemine Kolay İK ile kavuştuk. DİLAYYLAYYY",
                NumberOfEmployees = 1
            };
            return PartialView("_DetailsPartial", comment);
        }

    }
}
