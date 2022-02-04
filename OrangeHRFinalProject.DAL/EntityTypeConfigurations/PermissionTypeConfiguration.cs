using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OrangeHRFinalProject.Entities.Concretes;
using OrangeHRFinalProject.Entities.Enums;

namespace OrangeHRFinalProject.DAL.EntityTypeConfigurations
{
    public class PermissionTypeConfiguration : IEntityTypeConfiguration<Permission>
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
            builder.HasOne(m => m.Manager)
                   .WithMany(m => m.GivenPermissions)
                   .HasForeignKey(m => m.ManagerId)
                   .OnDelete(DeleteBehavior.NoAction);
            builder.Property(m => m.Status)
                   .HasDefaultValue(Status.Pending);
        }
    }
}
