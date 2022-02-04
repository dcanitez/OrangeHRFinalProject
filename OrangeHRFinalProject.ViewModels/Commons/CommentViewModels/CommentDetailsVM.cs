using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRFinalProject.ViewModels.Commons.CommentViewModels
{
    public class CommentDetailsVM
    {
        //Comment Props
        public int CommentId { get; set; }
        public int ManagerId { get; set; }
        public string ShortDescription { get; set; }
        public string Details { get; set; }
        //Employee Props
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhotoFilePath { get; set; }        
        //Company Props
        public string CompanyName { get; set; }
        public int NumberOfEmployees { get; set; }
        public string CompanyLogoPath { get; set; }
    }
}
