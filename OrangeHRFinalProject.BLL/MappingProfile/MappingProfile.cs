using AutoMapper;
using OrangeHRFinalProject.Entities.Authentication;
using OrangeHRFinalProject.Entities.Concretes;
using OrangeHRFinalProject.Entities.Enums;
using OrangeHRFinalProject.ViewModels.Combined.AccountViewModels.RegisterVM;
using OrangeHRFinalProject.ViewModels.Combined.AdministrationViewModels;
using OrangeHRFinalProject.ViewModels.Combined.ManagerViewModels.MainPageVM;
using OrangeHRFinalProject.ViewModels.Commons.CommentViewModels;
using OrangeHRFinalProject.ViewModels.Commons.CompanyViewModels;
using OrangeHRFinalProject.ViewModels.Commons.DepartmentViewModels;
using OrangeHRFinalProject.ViewModels.Commons.EmployeeViewModels;
using OrangeHRFinalProject.ViewModels.Commons.HolidayViewModels;
using OrangeHRFinalProject.ViewModels.Commons.MembershipViewModels;
using OrangeHRFinalProject.ViewModels.Commons.PermissionTypeViewModels;
using OrangeHRFinalProject.ViewModels.Commons.PermissionViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRFinalProject.BLL.MappingProfile
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<UserRegisterVM, ApplicationUser>()
                .ForMember(m => m.UserName, opt => opt.MapFrom(src => src.Employee.CorporateEMail))
                .ForMember(m => m.Email, opt => opt.MapFrom(src => src.Employee.CorporateEMail))
                .ForMember(m => m.FirstName, opt => opt.MapFrom(src => src.Employee.FirstName))
                .ForMember(m => m.LastName, opt => opt.MapFrom(src => src.Employee.LastName))
                .ForMember(m => m.FieldName, opt => opt.MapFrom(src => src.Employee.LastName + src.Employee.FirstName + '_' + src.Company.CompanyName));
            CreateMap<UserRegisterVM, CompanyCreateVM>()
                .ForMember(m => m.CompanyName, opt => opt.MapFrom(src => src.Company.CompanyName))
                .ForMember(m => m.NumberofEmployee, opt => opt.MapFrom(src => src.Company.NumberofEmployee))
                .ForMember(m => m.Sector, opt => opt.MapFrom(src => src.Company.Sector));
            CreateMap<UserRegisterVM, EmployeeCreateVM>()
                .ForMember(m => m.CorporateEMail, opt => opt.MapFrom(src => src.Employee.CorporateEMail))
                .ForMember(m => m.CorporatePhoneNumber, opt => opt.MapFrom(src => src.Employee.CorporatePhoneNumber))
                .ForMember(m => m.FirstName, opt => opt.MapFrom(src => src.Employee.FirstName))
                .ForMember(m => m.LastName, opt => opt.MapFrom(src => src.Employee.LastName))
                .ForMember(m => m.IsDataProtectionRead, opt => opt.MapFrom(src => src.Employee.IsDataProtectionRead));

            CreateMap<CompanyCreateVM, Company>()
                .ForMember(m => m.Name, opt => opt.MapFrom(src => src.CompanyName))
                .ForMember(m => m.NumberOfEmployees, opt => opt.MapFrom(src => src.NumberofEmployee))
                .ForMember(m => m.Sector, opt => opt.MapFrom(src => src.Sector));
            CreateMap<Company, ViewModels.Commons.CompanyViewModels.CompanyDetailsVM>();
            CreateMap<CompanyUpdateVM, Company>();

            CreateMap<Company, CompanyMembershipDetailsVM>()
                .ForMember(m => m.CompanyName, opt => opt.MapFrom(src => src.Name))
                .ForMember(m => m.MembershipEndDate, opt => opt.MapFrom(src => src.MembershipEndDate.Value.ToShortDateString()));

            CreateMap<EmployeeCreateVM, Employee>();
            CreateMap<Employee, EmployeeDetailsVM>();
            CreateMap<EmployeeUpdateVM, Employee>();

            CreateMap<Employee, BirthDayVM>()
                .ForMember(m => m.EmployeeFullName, opt => opt.MapFrom(src => src.FirstName + ' ' + src.LastName))
                .ForMember(m => m.BirthDay, opt => opt.MapFrom(src => src.BirthDay.Value.ToShortDateString()));

            CreateMap<HolidayCreateVM, Holiday>();
            CreateMap<Holiday, HolidayDetailsVM>()
                .ForMember(m => m.Description,opt=> opt.MapFrom(src => src.Description))
                .ForMember(m => m.StartDate,opt=> opt.MapFrom(src => src.StartDate.ToString("dd.MM.yyy")))
                .ForMember(m => m.EndDate,opt=> opt.MapFrom(src => src.EndDate.ToString("dd.MM.yyy")));
            CreateMap<HolidayUpdateVM, Holiday>();

            CreateMap<MembershipCreateVM, Membership>();
            CreateMap<Membership, MembershipDetailsVM>();
            CreateMap<MembershipUpdateVM, Membership>();

            CreateMap<Comment, CommentDetailsVM>()
                .ForMember(m => m.CommentId, opt => opt.MapFrom(src => src.Id))
                .ForMember(m => m.ManagerId, opt => opt.MapFrom(src => src.ManagerId))
                .ForMember(m => m.FirstName, opt => opt.MapFrom(src => src.Employee.FirstName))
                .ForMember(m => m.LastName, opt => opt.MapFrom(src => src.Employee.LastName))
                .ForMember(m=>m.PhotoFilePath,opt=>opt.MapFrom(src=>src.Employee.PhotoFilePath))
                .ForMember(m=>m.CompanyName,opt=>opt.MapFrom(src=>src.Employee.Company.Name))
                .ForMember(m=>m.CompanyLogoPath,opt=>opt.MapFrom(src=>src.Employee.Company.CompanyLogoPath));

            CreateMap<Permission, PermissionVM>()
                .ForMember(m => m.EmployeeFullName, opt => opt.MapFrom(src => src.Employee.FirstName + ' ' + src.Employee.LastName))
                .ForMember(m => m.StartDate, opt => opt.MapFrom(src => src.StartDate.ToShortDateString()));
            CreateMap<PermissionCreateVM, Permission>()
                .ForMember(m => m.EmployeeId, opt => opt.MapFrom(src => src.EmployeeId))
                .ForMember(m=>m.PermissionTypeId,opt=>opt.MapFrom(src=>src.PermissionTypeId))
                .ForMember(m=>m.StartDate,opt=>opt.MapFrom(src=>src.StartDate))
                .ForMember(m=>m.EndDate,opt=>opt.MapFrom(src=>src.EndDate));

            CreateMap<PermissionType, PermissionTypeDetailsVM>()
                .ForMember(m => m.TypeId, opt => opt.MapFrom(src => src.Id))
                .ForMember(m => m.Description, opt => opt.MapFrom(src => src.Description));


            CreateMap<Title, EmployeeTitleDetailsVM>()
                .ForMember(m => m.Title, opt => opt.MapFrom(src => src.Description))
                .ForMember(m => m.NumberOfPersonels, opt => opt.MapFrom(src => src.Employees.Count));

            CreateMap<Department, EmployeeDepartmentDetailsVM>()
                .ForMember(m => m.DepartmentName, opt => opt.MapFrom(src => src.Description))
                .ForMember(m => m.NumberOfPersonels, opt => opt.MapFrom(src => src.Employees.Count));

            CreateMap<DepartmentCreateVM, Department>();
            CreateMap<Department, DepartmentDetailsVM>()
                .ForMember(m=>m.Id,opt=>opt.MapFrom(src=>src.Id))
                .ForMember(m=>m.Description,opt=>opt.MapFrom(src=>src.Description))
                .ForMember(m=>m.NumberOfEmployees,opt=>opt.MapFrom(src=>src.Employees.Count));
            CreateMap<DepartmentUpdateVM, Department>();

        }
    }
}
