using OrangeHRFinalProject.Entities.Common;
using System;

namespace OrangeHRFinalProject.Entities.Concretes
{
    public class Liability : EntityBase
    {
        public string SerialNumber { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public LiabilityCategory Category { get; set; }
        public DateTime GivenDate { get; set; }
        public DateTime? TakenDate { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public int? ManagerId { get; set; }
        public string ManagerFullName { get; set; }
        public Employee Manager { get; set; }
    }
}
