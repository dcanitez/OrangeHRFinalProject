using OrangeHRFinalProject.ViewModels.CompanyViewModels;
using OrangeHRFinalProject.ViewModels.HolidayViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRFinalProject.ViewModels.AdministrationViewModels
{
    public class AdminMainVM
    {
        public AdminMainVM()
        {
            Holidays = new List<HolidayDetailsVM>();
            Companies = new List<CompanyDetailsVM>();
        }
        
        public int NumberOfManagers { get; set; }
        public int NumberOfPersonels { get; set; }        
        public List<CompanyDetailsVM> Companies { get; set; }    
        public List<HolidayDetailsVM> Holidays { get; set; }       

    }
}
