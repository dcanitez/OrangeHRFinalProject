using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OrangeHRFinalProject.Entities.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRFinalProject.DAL.EntityTypeConfigurations
{
    public class ApplicationRoleTypeConfiguration : IEntityTypeConfiguration<ApplicationRole>
    {
        public void Configure(EntityTypeBuilder<ApplicationRole> builder)
        {
            builder.HasData(
                new ApplicationRole { Id=1,Name="admin", NormalizedName="ADMIN"},
                new ApplicationRole { Id=2,Name="manager", NormalizedName="MANAGER"},
                new ApplicationRole { Id=3,Name="personel", NormalizedName="PERSONEL"}
                );
        }
    }
}
