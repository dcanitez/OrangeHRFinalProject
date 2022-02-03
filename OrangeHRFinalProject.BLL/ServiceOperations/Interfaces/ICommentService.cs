using OrangeHRFinalProject.BLL.ServiceOperations.Common;
using OrangeHRFinalProject.Entities.Concretes;
using OrangeHRFinalProject.ViewModels.Commons.CommentViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRFinalProject.BLL.ServiceOperations.Interfaces
{
    public interface ICommentService:IServiceOperations<Comment,CommentDetailsVM,CommentCreateVM,CommentUpdateVM>
    {
        Task<List<CommentDetailsVM>> GetAllCommentDetails();
        Task<CommentDetailsVM> GetByIdWithDetails(int id);
    }
}
