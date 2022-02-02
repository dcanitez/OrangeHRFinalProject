using System;

namespace OrangeHRFinalProject.ViewModels.PermissionViewModels
{
    public class PermissionCreateVM
    {
        //employee id bilgisini giriş yapan kullanıcıdan almamız lazım.
        //public int EmployeeId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Description { get; set; }
    }
}
