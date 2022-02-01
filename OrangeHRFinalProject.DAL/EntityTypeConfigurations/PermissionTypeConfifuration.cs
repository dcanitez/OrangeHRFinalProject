using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OrangeHRFinalProject.Entities.Concretes;

namespace OrangeHRFinalProject.DAL.EntityTypeConfigurations
{
    public class PermissionTypeConfifuration : IEntityTypeConfiguration<Permission>
    {
        public void Configure(EntityTypeBuilder<Permission> builder)
        {
            builder.HasKey(m => m.Id);
            builder.HasOne(m => m.PermissionType)
                   .WithMany(m => m.Permissions)
                   .HasForeignKey(m => m.PermissionTypeId);
            builder.HasOne(m => m.Employee)
                   .WithMany(m => m.Permissions)
                   .HasForeignKey(m => m.EmployeeId);
        }
    }
}
