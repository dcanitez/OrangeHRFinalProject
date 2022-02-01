using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OrangeHRFinalProject.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRFinalProject.DAL.EntityTypeConfigurations
{
    public class CompanyTypeConfiguration : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.HasKey(m => m.Id);
            builder.Property(m => m.Sector).HasMaxLength(60).IsRequired();
            builder.HasOne(m => m.District)
                   .WithMany(m => m.Companies);
            builder.HasOne(m => m.Membership)
                   .WithMany(m => m.Companies);
            builder.HasMany(m => m.Employees)
                   .WithOne(m => m.Company)
                   .HasForeignKey(m => m.CompanyId);
        }
    }
}
