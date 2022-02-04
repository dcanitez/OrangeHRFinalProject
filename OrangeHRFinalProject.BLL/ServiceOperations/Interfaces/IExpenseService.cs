using OrangeHRFinalProject.BLL.ServiceOperations.Common;
using OrangeHRFinalProject.Entities.Concretes;
using OrangeHRFinalProject.ViewModels.Commons.ExpenseViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRFinalProject.BLL.ServiceOperations.Interfaces
{
    public interface IExpenseService:IServiceOperations<Expense,ExpenseDetailsVM,ExpenseCreateVM,ExpenseUpdateVM>
    {
    }
}
