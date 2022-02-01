using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OrangeHRFinalProject.DAL.EntityTypeConfigurations;
using OrangeHRFinalProject.Entities.Authentication;
using OrangeHRFinalProject.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRFinalProject.DAL.Context
{
    public class ApplicationDbContext:IdentityDbContext<ApplicationUser,ApplicationRole,int>
    {
        private readonly IPasswordHasher<ApplicationUser> passwordHasher;
        private string configNameSpace = "OrangeHRFinalProject.DAL.EntityTypeConfigurations";
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options,IPasswordHasher<ApplicationUser> passwordHasher) :base(options)
        {
            this.passwordHasher = passwordHasher;
        }
        public DbSet<City> Cities{ get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Company> Companies{ get; set; }
        public DbSet<Country> Countries{ get; set; }
        public DbSet<Department> Departments{ get; set; }
        public DbSet<District> Districts{ get; set; }
        public DbSet<Employee> Employees{ get; set; }
        public DbSet<Holiday> Holidays { get; set; }
        public DbSet<Membership> Memberships{ get; set; }
        public DbSet<Permission> Permissions{ get; set; }
        public DbSet<PermissionType> PermissionTypes { get; set; }
        public DbSet<Title> Titles{ get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {            
            base.OnModelCreating(builder);
            builder.ApplyAllConfigurationsFromCurrentAssembly(Assembly.GetExecutingAssembly(), configNameSpace);
            builder.ApplyConfiguration(new ApplicationUserTypeConfiguration(passwordHasher));           
        }
    }
}
