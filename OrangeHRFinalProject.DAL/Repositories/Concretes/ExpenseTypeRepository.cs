using OrangeHRFinalProject.DAL.Context;
using OrangeHRFinalProject.DAL.Repositories.Common;
using OrangeHRFinalProject.DAL.Repositories.Interfaces;
using OrangeHRFinalProject.Entities.Concretes;

namespace OrangeHRFinalProject.DAL.Repositories.Concretes
{
    public class ExpenseTypeRepository : RepositoryBase<ExpenseType>, IExpenseTypeRepository
    {
        public ExpenseTypeRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }



}
