using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OrangeHRFinalProject.Entities.Concretes;

namespace OrangeHRFinalProject.DAL.EntityTypeConfigurations
{
    public class ExpenseTypeTypeConfiguration : IEntityTypeConfiguration<ExpenseType>
    {
        public void Configure(EntityTypeBuilder<ExpenseType> builder)
        {
            builder.HasKey(m => m.Id);
            builder.HasMany(m => m.Expenses)
                   .WithOne(m => m.ExpenseType)
                   .HasForeignKey(m => m.ExpenseTypeId);
            builder.HasData(new ExpenseType { Id = 1, Description = "Harcama" },
                            new ExpenseType { Id = 2, Description = "Avans" },
                            new ExpenseType { Id = 3, Description = "Prim" },
                            new ExpenseType { Id = 4, Description = "Mesai" },
                            new ExpenseType { Id = 5, Description = "İcra" },
                            new ExpenseType { Id = 6, Description = "Askerlik Yardımı" },
                            new ExpenseType { Id = 7, Description = "Bayram Yardımı" },
                            new ExpenseType { Id = 8, Description = "Yakacak Yardımı" });
        }
    }
}
