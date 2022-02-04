using OrangeHRFinalProject.Entities.Common;
using System;

namespace OrangeHRFinalProject.Entities.Concretes
{
    public class Break : EntityBase
    {
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public int ShiftId { get; set; }
        public Shift Shift { get; set; }
    }
}
