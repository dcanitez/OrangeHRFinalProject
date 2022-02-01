using OrangeHRFinalProject.Entities.Common;
using System.Collections.Generic;

namespace OrangeHRFinalProject.Entities.Concretes
{
    public class District:EntityBase
    {
        public District()
        {
            Companies = new HashSet<Company>();
            Employees = new HashSet<Employee>();
        }
        public string Name { get; set; }
        public int CityId { get; set; }
        public City City { get; set; }
        public ICollection<Company> Companies { get; set; }
        public ICollection<Employee> Employees { get; set; }
    }
}
