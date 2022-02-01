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
    public class HolidayTypeConfiguration : IEntityTypeConfiguration<Holiday>
    {
        public void Configure(EntityTypeBuilder<Holiday> builder)
        {
            builder.HasKey(m => m.Id);
            builder.HasData(
                new Holiday { Id = 1, Description = "Yeni Yıl Tatili", StartDate = new DateTime(2022, 1, 1), EndDate = new DateTime(2022, 1, 2) },
                new Holiday { Id = 2, Description = "Ulusal Egemenlik ve Çocuk Bayramı", StartDate = new DateTime(2022, 4, 23), EndDate = new DateTime(2022, 4, 23) },
                new Holiday { Id = 3, Description = "Emek ve Dayanışma Günü", StartDate = new DateTime(2022, 5, 1), EndDate = new DateTime(2022, 5, 1) },
                new Holiday { Id = 4, Description = "Ramazan Bayramı", StartDate = new DateTime(2022, 5, 2), EndDate = new DateTime(2022, 5, 5) },
                new Holiday { Id = 5, Description = "Atatürk'ü Anma Gençlik ve Spor Bayramı", StartDate = new DateTime(2022, 5, 19), EndDate = new DateTime(2022, 5, 19) },
                new Holiday { Id = 6, Description = "Kurban Bayramı", StartDate = new DateTime(2022, 7, 9), EndDate = new DateTime(2022, 7, 13) });

        }
    }
}
