using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OzelDersler.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OzelDersler.Data.Config
{
    public class UniversityConfig : IEntityTypeConfiguration<University>
    {
        public void Configure(EntityTypeBuilder<University> builder)
        {
            builder.HasKey(u => u.Id);
            builder.Property(u => u.Id).ValueGeneratedOnAdd();

            builder.Property(u => u.Name)
                .IsRequired()
                .HasMaxLength(50);

            builder.HasData(
                new University
                {
                    Id= 1,
                    Name="Bahçeşehir Üniversitesi"
                },
                new University
                {
                    Id = 2,
                    Name = "Beykent Üniversitesi"
                },
                new University
                {
                    Id = 3,
                    Name = "İstanbul Aydın Üniversitesi"
                },
                new University
                {
                    Id = 4,
                    Name = "İstanbul Teknik Üniversitesi"
                },
                new University
                {
                    Id = 5,
                    Name = "Orta Doğu Teknik Üniversitesi"
                }
                );
        }
    }
}
