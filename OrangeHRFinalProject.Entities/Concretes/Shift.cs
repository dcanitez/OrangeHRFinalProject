using OrangeHRFinalProject.Entities.Common;
using System;
using System.Collections.Generic;

namespace OrangeHRFinalProject.Entities.Concretes
{
    public class Shift : EntityBase
    {
        public Shift()
        {
            Breaks = new HashSet<Break>();
        }
        public string Description { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public DateTime ShiftStartDate { get; set; }
        public DateTime ShiftEndDate { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public int ManagerId { get; set; }
        public string ManagerFullName { get; set; }
        public Employee Manager { get; set; }
        public ICollection<Break> Breaks { get; set; }
    }
}
