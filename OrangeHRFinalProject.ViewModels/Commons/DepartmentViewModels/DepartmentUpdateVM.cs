using System;

namespace OrangeHRFinalProject.ViewModels.Commons.DepartmentViewModels
{
    public class DepartmentUpdateVM
    {
        public string Description { get; set; }
        public DateTime LastModifiedDate { get; set; } = DateTime.Now;
    }
}
