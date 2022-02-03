using OrangeHRFinalProject.ViewModels.Commons.CompanyViewModels;
using OrangeHRFinalProject.ViewModels.Commons.HolidayViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRFinalProject.ViewModels.Combined.AdministrationViewModels
{
    public class HolidayCompanyListVM
    {
        public List<HolidayDetailsVM> HolidayList { get; set; }
        public List<CompanyDetailsVM> CompanyList { get; set; }

    }
}
