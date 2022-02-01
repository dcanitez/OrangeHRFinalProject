using Microsoft.AspNetCore.Mvc;
using OrangeHRFinalProject.BLL.ServiceOperations.Interfaces;
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
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var list = await commentService.GetAllCommentDetails();
            return View(list);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Details(int id)
        {
            var comment = await commentService.GetByIdWithDetails(id);
            return View(comment);
        }

    }
}
