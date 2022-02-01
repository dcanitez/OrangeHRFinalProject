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
            services.AddScoped<IAdministrationService, AdministrationService>();
            services.AddScoped<IUserServiceOperations, ApplicationUserService>();
            services.AddScoped<ICommentService, CommentService>();
            services.AddScoped<ICompanyService, CompanyService>();
            services.AddScoped<IEmployeeService, EmployeeService>();
            services.AddScoped<IHolidayService, HolidayService>();
            //services.AddScoped(typeof(IServiceOperations<>), typeof(ServiceBase<>));
            return services;
        }
    }
}
