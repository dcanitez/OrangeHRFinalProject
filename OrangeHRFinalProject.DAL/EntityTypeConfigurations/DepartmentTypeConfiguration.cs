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
    public class DepartmentTypeConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasKey(m => m.Id);
            builder.Property(m => m.Description)
                   .IsRequired();
            builder.HasMany(m => m.Employees)
                   .WithOne(m => m.Department)
                   .HasForeignKey(m => m.DepartmentId);
            builder.HasData(new Department { Id = 1, Description = "Bilgi İşlem" },
                            new Department { Id = 2, Description = "Halkla İlişkiler" },
                            new Department { Id = 3, Description = "İnsan Kaynakları" },
                            new Department { Id = 4, Description = "Muhasebe ve Finans" },
                            new Department { Id = 5, Description = "Müşteri Hizmetleri" },
                            new Department { Id = 6, Description = "Satış Pazarlama" },
                            new Department { Id = 7, Description = "Yönetim" });

        }
    }
}
