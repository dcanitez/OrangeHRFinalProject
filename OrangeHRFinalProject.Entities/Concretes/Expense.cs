using OrangeHRFinalProject.Entities.Common;
using OrangeHRFinalProject.Entities.Enums;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRFinalProject.Entities.Concretes
{
    public class Expense:EntityBase
    {
        public Expense()
        {
            Receipts = new HashSet<Receipt>();
        }
        public string Description { get; set; }
        public int? ApprovedBy { get; set; }
        public string ManagerFullName { get; set; }
        public Employee Manager { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public int ExpenseTypeId { get; set;}
        public ExpenseType ExpenseType { get; set; }
        public Status Status { get; set; }
        public ICollection<Receipt> Receipts { get; set; }
    }
}
