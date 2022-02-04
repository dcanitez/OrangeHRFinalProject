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
    public class LiabilityTypeConfiguration : IEntityTypeConfiguration<Liability>
    {
        public void Configure(EntityTypeBuilder<Liability> builder)
        {
            builder.HasKey(m => m.Id);
            builder.HasOne(m => m.Category)
                   .WithMany(m => m.Liabilities)
                   .HasForeignKey(m => m.CategoryId);
            builder.HasOne(m => m.Employee)
                   .WithMany(m => m.Liabilities)
                   .HasForeignKey(m => m.EmployeeId);
            builder.HasOne(m => m.Manager)
                   .WithMany(m => m.GivenLiabilities)
                   .HasForeignKey(m => m.ManagerId)
                   .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
