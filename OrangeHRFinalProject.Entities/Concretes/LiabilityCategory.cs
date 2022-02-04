using OrangeHRFinalProject.Entities.Common;
using System.Collections.Generic;

namespace OrangeHRFinalProject.Entities.Concretes
{
    public class LiabilityCategory : EntityBase
    {
        public LiabilityCategory()
        {
            Liabilities = new HashSet<Liability>();
        }
        public string Description { get; set; }
        public ICollection<Liability> Liabilities { get; set; }
    }
}
