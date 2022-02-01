using OrangeHRFinalProject.Entities.Common;
using System.Collections.Generic;

namespace OrangeHRFinalProject.Entities.Concretes
{
    public class Membership:EntityBase
    {
        public Membership()
        {
            Companies = new HashSet<Company>();
        }
        private int _duration;
        public string Description { get; set; }
        public int Duration 
        {
            get
            {
                return _duration;
            }
            set
            {
                switch (Id)
                {
                    case 1:
                        _duration = 30;
                        break;
                    case 2:
                        _duration = 365;
                        break;
                }
            }
        }
        public ICollection<Company> Companies { get; set; }

    }
}
