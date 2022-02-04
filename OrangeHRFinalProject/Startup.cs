using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using OrangeHRFinalProject.Entities.Authentication;
using OrangeHRFinalProject.BLL.ServiceRegistration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OrangeHRFinalProject.DAL.Context;
using OrangeHRFinalProject.DAL.Repositories.Interfaces;
using OrangeHRFinalProject.DAL.Repositories.Common;
using OrangeHRFinalProject.DAL.Repositories.Concretes;
using Microsoft.EntityFrameworkCore;
using OrangeHRFinalProject.DAL.RepositoryRegistration;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;

namespace OrangeHRFinalProject
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddApplicationServices();
            services.AddAutoMapper(typeof(Startup));
            services.AddApplicationRepositories(Configuration);
            
            services.AddIdentity<ApplicationUser, ApplicationRole>(opt =>
            {
                opt.Password.RequiredLength = 8;
                opt.Password.RequireNonAlphanumeric = false;
                opt.Password.RequireUppercase = false;
                opt.Password.RequireLowercase = false;

                opt.User.RequireUniqueEmail = true;

            }).AddEntityFrameworkStores<ApplicationDbContext>().AddDefaultTokenProviders();            

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
