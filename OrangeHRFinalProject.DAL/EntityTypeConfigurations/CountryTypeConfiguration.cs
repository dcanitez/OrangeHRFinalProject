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
    public class CountryTypeConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.HasKey(m => m.Id);
            builder.HasMany(m => m.Cities)
                   .WithOne(m => m.Country)
                   .HasForeignKey(m=>m.CountryId);
            builder.Property(m => m.Name).HasMaxLength(100);
            builder.HasData(new Country { Id = 1, Name = "Türkiye"});
        }
    }
}
