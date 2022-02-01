using AutoMapper;
using OrangeHRFinalProject.Entities.Authentication;
using OrangeHRFinalProject.Entities.Concretes;
using OrangeHRFinalProject.ViewModels.AccountViewModels.LoginVM;
using OrangeHRFinalProject.ViewModels.AccountViewModels.RegisterVM;
using OrangeHRFinalProject.ViewModels.CommentViewModels;
using OrangeHRFinalProject.ViewModels.CompanyViewModels;
using OrangeHRFinalProject.ViewModels.EmployeeViewModels;
using OrangeHRFinalProject.ViewModels.HolidayViewModels;
using OrangeHRFinalProject.ViewModels.ManagerViewModels.MainPageVM;
using OrangeHRFinalProject.ViewModels.MembershipViewModels;
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
            CreateMap<Company, CompanyDetailsVM>();
            CreateMap<CompanyUpdateVM, Company>();

            CreateMap<EmployeeCreateVM, Employee>();
            CreateMap<Employee, EmployeeDetailsVM>();
            CreateMap<EmployeeUpdateVM, Employee>();

            CreateMap<Employee, BirthDayVM>()
                .ForMember(m => m.EmployeeFullName, opt => opt.MapFrom(src => src.FirstName + ' ' + src.LastName))
                .ForMember(m => m.BirthDay, opt => opt.MapFrom(src => src.BirthDay.Value.ToShortDateString()));

            CreateMap<HolidayCreateVM, Holiday>();
            CreateMap<Holiday, HolidayDetailsVM>()
                .ForMember(m=>m.Description,opt=>opt.MapFrom(src=>src.Description))
                .ForMember(m=>m.Date,opt=>opt.MapFrom(src=>src.StartDate.ToShortDateString()));
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
                

        }
    }
}
