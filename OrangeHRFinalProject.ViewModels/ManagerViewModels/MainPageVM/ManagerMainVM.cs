using OrangeHRFinalProject.ViewModels.EmployeeViewModels;
using OrangeHRFinalProject.ViewModels.HolidayViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRFinalProject.ViewModels.ManagerViewModels.MainPageVM
{
    public class ManagerMainVM
    {
        public List<EmployeeDetailsVM> Employees { get; set; }
        public List<BirthDayVM> BirthDayList { get; set; }
        public List<HolidayDetailsVM> HolidayList { get; set; }
        public List<PermissionVM> PermissionList { get; set; }
    }

    public class BirthDayVM
    {
        public string EmployeeFullName { get; set; }
        public string BirthDay { get; set; }
    }

    public class PermissionVM
    {
        public string EmployeeFullName { get; set; }
        public string StartDate { get; set; }
    }
}
