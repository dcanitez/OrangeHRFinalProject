using OrangeHRFinalProject.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRFinalProject.Entities.Concretes
{
    public class Company:EntityBase
    {
        public Company()
        {
            Employees = new HashSet<Employee>();
        }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Sector { get; set; }
        public int NumberOfEmployees { get; set; }
        public string CompanyLogoPath { get; set; }
        public bool IsActive { get; set; }
        public DateTime? MembershipStartDate { get; set; }
        public DateTime? MembershipEndDate { get; set; }        
        public int? DistrictId { get; set; }
        public District District { get; set; }
        public int? MembershipId { get; set; }
        public Membership Membership { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }

    }
}
