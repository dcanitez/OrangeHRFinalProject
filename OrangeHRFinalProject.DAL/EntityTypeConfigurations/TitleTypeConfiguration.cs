using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OrangeHRFinalProject.Entities.Concretes;

namespace OrangeHRFinalProject.DAL.EntityTypeConfigurations
{
    public class TitleTypeConfiguration : IEntityTypeConfiguration<Title>
    {
        public void Configure(EntityTypeBuilder<Title> builder)
        {
            builder.HasKey(m => m.Id);
            builder.Property(m => m.Description)
                   .IsRequired();
            builder.HasData(new Title { Id = 1,  Description = "Araştırma Mühendisi" },
                            new Title { Id = 2,  Description = "Destek Uzmanı" },
                            new Title { Id = 3,  Description = "Genel Müdür" },
                            new Title { Id = 4,  Description = "Genel Müdür Yardımcısı" },
                            new Title { Id = 5,  Description = "Halkla İlişkiler Uzmanı" },
                            new Title { Id = 6,  Description = "Hesap Yöneticisi" },
                            new Title { Id = 7,  Description = "İnsan Kaynakları Asistanı" },
                            new Title { Id = 8,  Description = "İnsan Kaynakları Direktörü" },
                            new Title { Id = 9,  Description = "Kurumsal İletişim Uzmanı" },
                            new Title { Id = 10, Description = "Kurumsal Satış Müdürü" },
                            new Title { Id = 11, Description = "Kurumsal Satış Sorumlusu" },
                            new Title { Id = 12, Description = "Maliye Sorumlusu" },
                            new Title { Id = 13, Description = "Muhasebe Asistanı" },
                            new Title { Id = 14, Description = "Muhasebe Sorumlusu" },
                            new Title { Id = 15, Description = "Müşteri İlişkileri Sorumlusu" },
                            new Title { Id = 16, Description = "Personel Müdürü" },
                            new Title { Id = 17, Description = "Satış Temsilcisi" },
                            new Title { Id = 18, Description = "Sistem Yöneticisi" },
                            new Title { Id = 19, Description = "Teknik Destek Uzmanı" },
                            new Title { Id = 20, Description = "Veritabanı Uzmanı" },
                            new Title { Id = 21, Description = "Yazılım Mühendisi" });

        }
    }
}
