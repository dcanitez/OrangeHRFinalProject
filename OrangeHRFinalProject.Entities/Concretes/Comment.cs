using OrangeHRFinalProject.Entities.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRFinalProject.Entities.Concretes
{
    public class Comment:EntityBase
    {
        public string ShortDescription { get; set; }
        public string Details { get; set; }
        public int ManagerId { get; set; }

        [ForeignKey("ManagerId")]
        public Employee Employee { get; set; }
    }
}
