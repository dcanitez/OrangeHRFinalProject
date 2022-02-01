using AutoMapper;
using OrangeHRFinalProject.BLL.ServiceOperations.Common;
using OrangeHRFinalProject.BLL.ServiceOperations.Interfaces;
using OrangeHRFinalProject.DAL.Repositories.Interfaces;
using OrangeHRFinalProject.Entities.Concretes;
using OrangeHRFinalProject.ViewModels.CommentViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRFinalProject.BLL.ServiceOperations.Concretes
{
    public class CommentService : ServiceBase<Comment, ICommentRepository, CommentDetailsVM, CommentCreateVM, CommentUpdateVM>, ICommentService
    {
        private readonly ICommentRepository service;
        private readonly IMapper mapper;
        public CommentService(ICommentRepository service, IMapper mapper) : base(service, mapper)
        {
            this.service = service;
            this.mapper = mapper;
        }     
        
        public async Task<List<CommentDetailsVM>> GetAllCommentDetails()
        {
            var result = await service.GetAsync(null,null,true,a=>a.Employee,a=>a.Employee.Company);
            List<CommentDetailsVM> list= mapper.Map<List<CommentDetailsVM>>(result);
            return list;            
        }

        public async Task<CommentDetailsVM> GetByIdWithDetails(int id)
        {
            var result = await service.GetAsync(a => a.Id == id, null, true, a => a.Employee, a => a.Employee.Company);
            return mapper.Map<CommentDetailsVM>(result);
        }
    }
}
