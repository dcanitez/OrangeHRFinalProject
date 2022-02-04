using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OrangeHRFinalProject.Entities.Concretes;
using OrangeHRFinalProject.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRFinalProject.DAL.EntityTypeConfigurations
{
    public class ExpenseTypeConfiguration : IEntityTypeConfiguration<Expense>
    {
        public void Configure(EntityTypeBuilder<Expense> builder)
        {
            builder.HasKey(m => m.Id);
            builder.HasOne(m => m.Manager)
                   .WithMany(m => m.ApprovedExpenses)
                   .HasForeignKey(m => m.ApprovedBy)
                   .OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(m => m.Employee)
                   .WithMany(m => m.Expenses)
                   .HasForeignKey(m => m.EmployeeId);
            builder.HasMany(m => m.Receipts)
                   .WithOne(m => m.Expense)
                   .HasForeignKey(m => m.ExpenseId);
            builder.Property(m => m.Status)
                   .HasDefaultValue(Status.Pending);
        }
    }
}
