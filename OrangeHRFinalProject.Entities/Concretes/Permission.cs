using OrangeHRFinalProject.Entities.Common;
using OrangeHRFinalProject.Entities.Enums;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRFinalProject.Entities.Concretes
{
    public class Permission : EntityBase
    {    
        
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string ApprovedBy { get; set; }
        public int PermissionTypeId { get; set; }
        public PermissionType PermissionType { get; set; }
        public Status Status { get; set; }
        public bool IsActive { get; set; }
        public int EmployeeId{ get; set; }
        public Employee Employee { get; set; }

    }
}
