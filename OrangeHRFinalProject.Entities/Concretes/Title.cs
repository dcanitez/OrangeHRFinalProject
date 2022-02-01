using OrangeHRFinalProject.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRFinalProject.Entities.Concretes
{
    public class Title:EntityBase
    {
        public Title()
        {
            Employees = new HashSet<Employee>();
        }
        public string Description { get; set; }
        public ICollection<Employee> Employees { get; set; }
    }
}
