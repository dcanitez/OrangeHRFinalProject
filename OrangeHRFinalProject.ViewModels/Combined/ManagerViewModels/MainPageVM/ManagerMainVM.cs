using OrangeHRFinalProject.ViewModels.Commons.EmployeeViewModels;
using OrangeHRFinalProject.ViewModels.Commons.HolidayViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRFinalProject.ViewModels.Combined.ManagerViewModels.MainPageVM
{
    public class ManagerMainVM
    {
        public List<EmployeeDepartmentDetailsVM> EmployeeDepartmentList { get; set; }
        public List<EmployeeTitleDetailsVM> EmployeeTitleList { get; set; }
        
    }

    public class EmployeeTitleDetailsVM
    {
        public string Title { get; set; }
        public int NumberOfPersonels { get; set; }
    }

    public class EmployeeDepartmentDetailsVM
    {
        public string DepartmentName { get; set; }
        public int NumberOfPersonels { get; set; }
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
