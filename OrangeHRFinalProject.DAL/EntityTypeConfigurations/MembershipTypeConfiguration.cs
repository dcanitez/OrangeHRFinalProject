using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OrangeHRFinalProject.Entities.Concretes;

namespace OrangeHRFinalProject.DAL.EntityTypeConfigurations
{
    public class MembershipTypeConfiguration : IEntityTypeConfiguration<Membership>
    {
        public void Configure(EntityTypeBuilder<Membership> builder)
        {
            builder.HasKey(m => m.Id);
            builder.HasMany(m => m.Companies)
                   .WithOne(m => m.Membership)
                   .HasForeignKey(m => m.MembershipId);

            builder.HasData(new Membership { Id = 1, Description = "Aylık Üyelik", Duration = 30 },
                            new Membership { Id = 2, Description = "Yıllık Üyelik", Duration = 365 });
        }
    }
}
