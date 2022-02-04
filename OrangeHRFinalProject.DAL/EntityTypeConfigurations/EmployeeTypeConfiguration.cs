using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OrangeHRFinalProject.Entities.Concretes;

namespace OrangeHRFinalProject.DAL.EntityTypeConfigurations
{
    public class EmployeeTypeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(m => m.Id);
            builder.Property(m => m.FirstName).HasMaxLength(60).IsRequired();
            builder.Property(m => m.LastName).HasMaxLength(70).IsRequired();
            builder.Property(m => m.CorporateEmail).IsRequired();
            builder.HasMany(m => m.Employees)
                   .WithOne(m => m.Manager)
                   .HasForeignKey(m => m.ManagerId);
            builder.HasOne(m => m.Company)
                   .WithMany(m => m.Employees)
                   .HasForeignKey(m => m.CompanyId);
            builder.HasOne(m => m.District)
                   .WithMany(m => m.Employees)
                   .HasForeignKey(m => m.DistrictId);
            builder.HasOne(m => m.Comment)
                   .WithOne(m => m.Employee);
            builder.HasMany(m => m.Holidays);
            builder.HasMany(m => m.Permissions)
                   .WithOne(e => e.Employee)
                   .HasForeignKey(e => e.EmployeeId);
            builder.HasMany(m => m.Expenses)
                   .WithOne(m => m.Employee)
                   .HasForeignKey(m => m.EmployeeId)
                   .OnDelete(DeleteBehavior.NoAction);
            builder.HasMany(m => m.ApprovedExpenses)
                   .WithOne(m => m.Manager)
                   .HasForeignKey(m => m.ApprovedBy);
            builder.HasMany(m => m.Liabilities)
                   .WithOne(m => m.Employee)
                   .HasForeignKey(m => m.EmployeeId);
            builder.HasMany(m => m.GivenLiabilities)
                   .WithOne(m => m.Manager)
                   .HasForeignKey(m => m.ManagerId);
            builder.HasMany(m => m.Shifts)
                   .WithOne(m => m.Employee)
                   .HasForeignKey(m => m.EmployeeId);
            builder.HasMany(m => m.GivenShifts)
                   .WithOne(m => m.Manager)
                   .HasForeignKey(m => m.ManagerId);
            builder.Property(m => m.Salary)
                   .HasColumnType("decimal")
                   .HasPrecision(8, 2);


        }
    }
}
