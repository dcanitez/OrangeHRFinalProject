using OrangeHRFinalProject.Entities.Common;
using System.Collections.Generic;

namespace OrangeHRFinalProject.Entities.Concretes
{
    public class Country : EntityBase
    {
        public Country()
        {
            Cities = new HashSet<City>();
        }
        public string Name { get; set; }
        public ICollection<City> Cities { get; set; }
    }
}
