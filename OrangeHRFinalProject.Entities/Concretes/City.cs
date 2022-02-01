using OrangeHRFinalProject.Entities.Common;
using System.Collections.Generic;

namespace OrangeHRFinalProject.Entities.Concretes
{
    public class City:EntityBase
    {
        public City()
        {
            Districts = new HashSet<District>();
        }
        public string CityName { get; set; }
        public int CountryId { get; set; }        
        public Country Country { get; set; }
        public ICollection<District> Districts { get; set; }
    }
}
