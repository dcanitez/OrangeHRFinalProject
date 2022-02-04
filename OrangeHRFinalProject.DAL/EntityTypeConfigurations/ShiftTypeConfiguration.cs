using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OrangeHRFinalProject.Entities.Concretes;

namespace OrangeHRFinalProject.DAL.EntityTypeConfigurations
{
    public class ShiftTypeConfiguration : IEntityTypeConfiguration<Shift>
    {
        public void Configure(EntityTypeBuilder<Shift> builder)
        {
            builder.HasKey(m => m.Id);
            builder.Property(m => m.StartTime)
                   .HasColumnType("time");
            builder.Property(m => m.EndTime)
                   .HasColumnType("time");
            builder.Property(m => m.ShiftStartDate)
                   .HasColumnType("date");
            builder.Property(m => m.ShiftEndDate)
                   .HasColumnType("date");
            builder.HasOne(m => m.Employee)
                   .WithMany(m => m.Shifts)
                   .HasForeignKey(m => m.EmployeeId);
            builder.HasOne(m => m.Manager)
                   .WithMany(m => m.GivenShifts)
                   .HasForeignKey(m => m.ManagerId)
                   .OnDelete(DeleteBehavior.NoAction);
            builder.HasMany(m => m.Breaks)
                   .WithOne(m => m.Shift)
                   .HasForeignKey(m => m.ShiftId);
        }
    }
}
