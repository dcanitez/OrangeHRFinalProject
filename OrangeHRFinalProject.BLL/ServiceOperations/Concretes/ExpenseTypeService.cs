using AutoMapper;
using OrangeHRFinalProject.BLL.ServiceOperations.Common;
using OrangeHRFinalProject.BLL.ServiceOperations.Interfaces;
using OrangeHRFinalProject.DAL.Repositories.Interfaces;
using OrangeHRFinalProject.Entities.Concretes;
using OrangeHRFinalProject.ViewModels.Commons.ExpenseTypeViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRFinalProject.BLL.ServiceOperations.Concretes
{
    public class ExpenseTypeService : ServiceBase<ExpenseType, IExpenseTypeRepository, ExpenseTypeDetailsVM, ExpenseTypeCreateVM, ExpenseTypeUpdateVM>,IExpenseTypeService
    {
        private readonly IExpenseTypeRepository service;
        private readonly IMapper mapper;

        public ExpenseTypeService(IExpenseTypeRepository service, IMapper mapper) : base(service, mapper)
        {
            this.service = service;
            this.mapper = mapper;
        }
    }
}
