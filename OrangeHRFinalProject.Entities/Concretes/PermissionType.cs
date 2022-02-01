using OrangeHRFinalProject.Entities.Common;
using System.Collections.Generic;

namespace OrangeHRFinalProject.Entities.Concretes
{
    public class PermissionType: EntityBase
    {
        public PermissionType()
        {
            Permissions = new HashSet<Permission>();
        }
        public string Description { get; set; }   
        public ICollection<Permission> Permissions { get; set; }
    }
}
