using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OrangeHRFinalProject.Entities.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRFinalProject.DAL.Context
{
    public class ApplicationUserTypeConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        private readonly IPasswordHasher<ApplicationUser> passwordHasher;
        public ApplicationUserTypeConfiguration(IPasswordHasher<ApplicationUser> passwordHasher)
        {
            this.passwordHasher = passwordHasher;
        }
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            ApplicationUser user = new ApplicationUser();
            user.Id = 1;
            user.UserName = "admin";
            user.NormalizedUserName = "ADMIN";
            user.Email = "admin@mail.com";
            user.NormalizedEmail = "admin@mail.com";
            user.EmailConfirmed = true;
            user.PasswordHash = passwordHasher.HashPassword(user, "123456789");
            user.SecurityStamp = Guid.NewGuid().ToString();
            user.IsActive = true;
            
            builder.HasData(user);            
        }
    }
}
