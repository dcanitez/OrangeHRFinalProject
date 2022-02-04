using OrangeHRFinalProject.Entities.Common;
using OrangeHRFinalProject.Entities.Enums;
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
            GivenPermissions = new HashSet<Permission>();
            Expenses = new HashSet<Expense>();
            ApprovedExpenses = new HashSet<Expense>();
            Liabilities = new HashSet<Liability>();
            GivenLiabilities = new HashSet<Liability>();
            Shifts = new HashSet<Shift>();
            GivenShifts = new HashSet<Shift>();
        }
        public string IdentityNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender? Gender { get; set; }
        public MaritalStatus? MaritalStatus { get; set; }
        public EducationStatus? EducationStatus { get; set; }
        public string GraduatedSchool { get; set; }
        public string GraduatedDepartment { get; set; }
        public decimal? Salary { get; set; }
        public int? NumberOfChildren { get; set; }
        public string Address { get; set; }
        public string CorporateEmail { get; set; }
        public string CorporatePhoneNumber { get; set; }
        public string FieldName { get; set; }
        public string PersonalEmail { get; set; }
        public string PersonalPhoneNumber { get; set; }
        public DateTime? BirthDay { get; set; }
        public DateTime? JobStartDate { get; set; }
        public AccessType AccessType { get; set; }
        public ContractType? ContractType { get; set; }
        public DateTime? ContractEndDate { get; set; }
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
        public ICollection<Permission> GivenPermissions { get; set; }
        public ICollection<Expense> Expenses { get; set; }
        public ICollection<Expense> ApprovedExpenses { get; set; }
        public ICollection<Liability> Liabilities { get; set; }
        public ICollection<Liability> GivenLiabilities { get; set; }
        public ICollection<Shift> Shifts { get; set; }
        public ICollection<Shift> GivenShifts { get; set; }
    }
}
