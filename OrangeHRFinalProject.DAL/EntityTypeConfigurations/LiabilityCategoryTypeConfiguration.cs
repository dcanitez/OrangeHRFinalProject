using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OrangeHRFinalProject.Entities.Concretes;

namespace OrangeHRFinalProject.DAL.EntityTypeConfigurations
{
    public class LiabilityCategoryTypeConfiguration : IEntityTypeConfiguration<LiabilityCategory>
    {
        public void Configure(EntityTypeBuilder<LiabilityCategory> builder)
        {
            builder.HasKey(m => m.Id);
            builder.HasMany(m => m.Liabilities)
                   .WithOne(m => m.Category)
                   .HasForeignKey(m => m.CategoryId);
            builder.HasData(new LiabilityCategory { Id = 1, Description = "Bilgisayar" },
                            new LiabilityCategory { Id = 2, Description = "Cep Telefonu" },
                            new LiabilityCategory { Id = 3, Description = "Araç" });
        }
    }
}
