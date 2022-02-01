using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OrangeHRFinalProject.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRFinalProject.DAL.EntityTypeConfigurations
{
    public class CityTypeConfiguration : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.HasKey(m => m.Id);
            builder.Property(m => m.CityName).HasMaxLength(100).IsRequired();
            builder.HasOne(m => m.Country)
                   .WithMany(m => m.Cities)
                   .IsRequired();            
            builder.HasData(
                new City { Id = 1, CityName = "Adana", CountryId = 1 },
                new City { Id = 2, CityName = "Adıyaman", CountryId = 1 },
                new City { Id = 3, CityName = "Afyonkarahisar", CountryId = 1 },
                new City { Id = 4, CityName = "Ağrı", CountryId = 1 },
                new City { Id = 5, CityName = "Amasya", CountryId = 1 },
                new City { Id = 6, CityName = "Ankara", CountryId = 1 },
                new City { Id = 7, CityName = "Antalya", CountryId = 1 },
                new City { Id = 8, CityName = "Artvin", CountryId = 1 },
                new City { Id = 9, CityName = "Aydın", CountryId = 1 },
                new City { Id = 10, CityName = "Balıkesir", CountryId = 1 },
                new City { Id = 11, CityName = "Bilecik", CountryId = 1 },
                new City { Id = 12, CityName = "Bingöl", CountryId = 1 },
                new City { Id = 13, CityName = "Bitlis", CountryId = 1 },
                new City { Id = 14, CityName = "Bolu", CountryId = 1 },
                new City { Id = 15, CityName = "Burdur", CountryId = 1 },
                new City { Id = 16, CityName = "Bursa", CountryId = 1 },
                new City { Id = 17, CityName = "Çanakkale", CountryId = 1 },
                new City { Id = 18, CityName = "Çankırı", CountryId = 1 },
                new City { Id = 19, CityName = "Çorum", CountryId = 1 },
                new City { Id = 20, CityName = "Denizli", CountryId = 1 },
                new City { Id = 21, CityName = "Diyarbakır", CountryId = 1 },
                new City { Id = 22, CityName = "Edirne", CountryId = 1 },
                new City { Id = 23, CityName = "Elazığ", CountryId = 1 },
                new City { Id = 24, CityName = "Erzincan", CountryId = 1 },
                new City { Id = 25, CityName = "Erzurum", CountryId = 1 },
                new City { Id = 26, CityName = "Eskişehir", CountryId = 1 },
                new City { Id = 27, CityName = "Gaziantep", CountryId = 1 },
                new City { Id = 28, CityName = "Giresun", CountryId = 1 },
                new City { Id = 29, CityName = "Gümüşhane", CountryId = 1 },
                new City { Id = 30, CityName = "Hakkari", CountryId = 1 },
                new City { Id = 31, CityName = "Hatay", CountryId = 1 },
                new City { Id = 32, CityName = "Isparta", CountryId = 1 },
                new City { Id = 33, CityName = "Mersin", CountryId = 1 },
                new City { Id = 34, CityName = "İstanbul", CountryId = 1 },
                new City { Id = 35, CityName = "İzmir", CountryId = 1 },
                new City { Id = 36, CityName = "Kars", CountryId = 1 },
                new City { Id = 37, CityName = "Kastamonu", CountryId = 1 },
                new City { Id = 38, CityName = "Kayseri", CountryId = 1 },
                new City { Id = 39, CityName = "Kırklareli", CountryId = 1 },
                new City { Id = 40, CityName = "Kırşehir", CountryId = 1 },
                new City { Id = 41, CityName = "Kocaeli", CountryId = 1 },
                new City { Id = 42, CityName = "Konya", CountryId = 1 },
                new City { Id = 43, CityName = "Kütahya", CountryId = 1 },
                new City { Id = 44, CityName = "Malatya", CountryId = 1 },
                new City { Id = 45, CityName = "Manisa", CountryId = 1 },
                new City { Id = 46, CityName = "Kahramanmaraş", CountryId = 1 },
                new City { Id = 47, CityName = "Mardin", CountryId = 1 },
                new City { Id = 48, CityName = "Muğla", CountryId = 1 },
                new City { Id = 49, CityName = "Muş", CountryId = 1 },
                new City { Id = 50, CityName = "Nevşehir", CountryId = 1 },
                new City { Id = 51, CityName = "Niğde", CountryId = 1 },
                new City { Id = 52, CityName = "Ordu", CountryId = 1 },
                new City { Id = 53, CityName = "Rize", CountryId = 1 },
                new City { Id = 54, CityName = "Sakarya", CountryId = 1 },
                new City { Id = 55, CityName = "Samsun", CountryId = 1 },
                new City { Id = 56, CityName = "Siirt", CountryId = 1 },
                new City { Id = 57, CityName = "Sinop", CountryId = 1 },
                new City { Id = 58, CityName = "Sivas", CountryId = 1 },
                new City { Id = 59, CityName = "Tekirdağ", CountryId = 1 },
                new City { Id = 60, CityName = "Tokat", CountryId = 1 },
                new City { Id = 61, CityName = "Trabzon", CountryId = 1 },
                new City { Id = 62, CityName = "Tunceli", CountryId = 1 },
                new City { Id = 63, CityName = "Şanlıurfa", CountryId = 1 },
                new City { Id = 64, CityName = "Uşak", CountryId = 1 },
                new City { Id = 65, CityName = "Van", CountryId = 1 },
                new City { Id = 66, CityName = "Yozgat", CountryId = 1 },
                new City { Id = 67, CityName = "Zonguldak", CountryId = 1 },
                new City { Id = 68, CityName = "Aksaray", CountryId = 1 },
                new City { Id = 69, CityName = "Bayburt", CountryId = 1 },
                new City { Id = 70, CityName = "Karaman", CountryId = 1 },
                new City { Id = 71, CityName = "Kırıkkale", CountryId = 1 },
                new City { Id = 72, CityName = "Batman", CountryId = 1 },
                new City { Id = 73, CityName = "Şırnak", CountryId = 1 },
                new City { Id = 74, CityName = "Bartın", CountryId = 1 },
                new City { Id = 75, CityName = "Ardahan", CountryId = 1 },
                new City { Id = 76, CityName = "Iğdır", CountryId = 1 },
                new City { Id = 77, CityName = "Yalova", CountryId = 1 },
                new City { Id = 78, CityName = "Karabük", CountryId = 1 },
                new City { Id = 79, CityName = "Kilis", CountryId = 1 },
                new City { Id = 80, CityName = "Osmaniye", CountryId = 1 },
                new City { Id = 81, CityName = "Düzce", CountryId = 1 });                  
                
        }
    }
}
