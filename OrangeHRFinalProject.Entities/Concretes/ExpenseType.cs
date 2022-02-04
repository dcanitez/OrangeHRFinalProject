using OrangeHRFinalProject.Entities.Common;
using System.Collections.Generic;

namespace OrangeHRFinalProject.Entities.Concretes
{
    public class ExpenseType : EntityBase
    {
        public ExpenseType()
        {
            Expenses = new HashSet<Expense>();
        }

        public string Description { get; set; }
        public virtual ICollection<Expense> Expenses { get; set; }
    }
}
