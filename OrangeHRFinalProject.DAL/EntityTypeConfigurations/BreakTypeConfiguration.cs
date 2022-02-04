using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OrangeHRFinalProject.Entities.Concretes;

namespace OrangeHRFinalProject.DAL.EntityTypeConfigurations
{
    public class BreakTypeConfiguration : IEntityTypeConfiguration<Break>
    {
        public void Configure(EntityTypeBuilder<Break> builder)
        {
            builder.HasKey(m => m.Id);
            builder.Property(m => m.StartTime)
                   .HasColumnType("time");
            builder.Property(m => m.EndTime)
                   .HasColumnType("time");
        }
    }
}
