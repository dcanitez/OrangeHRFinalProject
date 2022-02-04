using Microsoft.Extensions.DependencyInjection;
using OrangeHRFinalProject.BLL.ServiceOperations.Concretes;
using OrangeHRFinalProject.BLL.ServiceOperations.Interfaces;
using OrangeHRFinalProject.BLL.ServiceOperations.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRFinalProject.BLL.ServiceRegistration
{
    public static class ApplicationServiceRegistration
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());            
            services.AddScoped<IBreakService, BreakService>();
            services.AddScoped<ICityService, CityService>();
            services.AddScoped<ICommentService, CommentService>();
            services.AddScoped<ICompanyService, CompanyService>();
            services.AddScoped<ICountryService, CountryService>();
            services.AddScoped<IDepartmentService, DepartmentService>();
            services.AddScoped<IDistrictService, DistrictService>();
            services.AddScoped<IEmployeeService, EmployeeService>();
            services.AddScoped<IExpenseService, ExpenseService>();
            services.AddScoped<IExpenseTypeService, ExpenseTypeService>();
            services.AddScoped<IHolidayService, HolidayService>();
            services.AddScoped<ILiabilityService, LiabilityService>();
            services.AddScoped<ILiabilityCategoryService, LiabilityCategoryService>();
            services.AddScoped<IMembershipService, MembershipService>();
            services.AddScoped<IPermissionService, PermissionService>();
            services.AddScoped<IPermissionTypeService, PermissionTypeService>();
            services.AddScoped<IReceiptService, ReceiptService>();
            services.AddScoped<IShiftService, ShiftService>();
            services.AddScoped<ITitleService, TitleService>();
            services.AddScoped<IUserServiceOperations, ApplicationUserService>();
            //services.AddScoped(typeof(IServiceOperations<>), typeof(ServiceBase<>));
            return services;
        }
    }
}
