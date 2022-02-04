using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OrangeHRFinalProject.Entities.Concretes;

namespace OrangeHRFinalProject.DAL.EntityTypeConfigurations
{
    public class PermissionTypeTypeConfiguration : IEntityTypeConfiguration<PermissionType>
    {
        public void Configure(EntityTypeBuilder<PermissionType> builder)
        {
            builder.HasKey(m => m.Id);
            builder.HasMany(m => m.Permissions)
                   .WithOne(m => m.PermissionType)
                   .HasForeignKey(m => m.PermissionTypeId);
            builder.HasData(new PermissionType { Id = 1, Description = "Yıllık İzin" },
                            new PermissionType { Id = 2, Description = "Doğum Sonrası İzni" },
                            new PermissionType { Id = 3, Description = "Vefat İzni" },
                            new PermissionType { Id = 4, Description = "Süt İzni" },
                            new PermissionType { Id = 5, Description = "Mazeret İzni" },
                            new PermissionType { Id = 6, Description = "İş Arama İzni" },
                            new PermissionType { Id = 7, Description = "Evlilik İzni" },
                            new PermissionType { Id = 8, Description = "Doğum İzni" },
                            new PermissionType { Id = 9, Description = "Askerlik İzni" },
                            new PermissionType { Id = 10, Description = "Babalık İzni" },
                            new PermissionType { Id = 11, Description = "Yol İzni" },
                            new PermissionType { Id = 12, Description = "Hastalık İzni" },
                            new PermissionType { Id = 13, Description = "Ücretsiz İzin" });
        }
    }
}
