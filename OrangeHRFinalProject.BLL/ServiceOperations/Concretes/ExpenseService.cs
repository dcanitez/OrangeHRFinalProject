using AutoMapper;
using OrangeHRFinalProject.BLL.ServiceOperations.Common;
using OrangeHRFinalProject.BLL.ServiceOperations.Interfaces;
using OrangeHRFinalProject.DAL.Repositories.Interfaces;
using OrangeHRFinalProject.Entities.Concretes;
using OrangeHRFinalProject.ViewModels.Commons.ExpenseViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRFinalProject.BLL.ServiceOperations.Concretes
{
    public class ExpenseService : ServiceBase<Expense, IExpenseRepository, ExpenseDetailsVM, ExpenseCreateVM, ExpenseUpdateVM>,IExpenseService
    {
        private readonly IExpenseRepository service;
        private readonly IMapper mapper;

        public ExpenseService(IExpenseRepository service, IMapper mapper) : base(service, mapper)
        {
            this.service = service;
            this.mapper = mapper;
        }
    }
}
