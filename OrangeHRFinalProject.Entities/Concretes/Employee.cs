using OrangeHRFinalProject.Entities.Common;
using System;
using System.Collections.Generic;

namespace OrangeHRFinalProject.Entities.Concretes
{
    public class Employee:EntityBase
    {
        public Employee()
        {
            Employees = new HashSet<Employee>();
            Holidays = new HashSet<Holiday>();
            Permissions = new HashSet<Permission>();
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string CorporateEmail { get; set; }
        public string CorporatePhoneNumber { get; set; }
        public string FieldName { get; set; }
        public string PersonalEmail { get; set; }
        public string PersonalPhoneNumber { get; set; }
        public DateTime? BirthDay { get; set; }
        public bool IsActive { get; set; }
        public bool IsDataProtectionRead { get; set; }
        public string PhotoFilePath { get; set; }
        public int? CommentId { get; set; }
        public Comment Comment { get; set; }
        public int? ManagerId { get; set; }
        public Employee Manager { get; set; }
        public int? DistrictId { get; set; }
        public District District { get; set; }
        public int? CompanyId { get; set; }
        public Company Company { get; set; }
        public int? DepartmentId { get; set; }
        public Department Department{ get; set; }
        public int? TitleId { get; set; }
        public Title Title { get; set; }
        public ICollection<Employee> Employees { get; set; }
        public ICollection<Holiday> Holidays { get; set; }
        public ICollection<Permission> Permissions { get; set; }
    }
}
