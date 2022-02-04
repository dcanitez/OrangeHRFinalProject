using OrangeHRFinalProject.Entities.Common;

namespace OrangeHRFinalProject.Entities.Concretes
{
    public class Receipt : EntityBase
    {
        public string Description { get; set; }
        public string PhotoFilePath { get; set; }
        public int ExpenseId { get; set; }
        public Expense Expense { get; set; }
    }
}
