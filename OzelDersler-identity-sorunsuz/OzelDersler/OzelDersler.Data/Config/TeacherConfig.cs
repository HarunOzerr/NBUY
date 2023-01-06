using OzelDersler.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace OzelDersler.Data.Config
{
    public class TeacherConfig : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Id).ValueGeneratedOnAdd();

            builder.Property(t => t.FirstName).IsRequired();
            builder.Property(t => t.FirstName).HasMaxLength(50);
            builder.Property(t => t.LastName).IsRequired();
            builder.Property(t => t.LastName).HasMaxLength(50);

            builder.Property(t => t.BirthYear).IsRequired();

            builder.Property(t => t.About).IsRequired();
            builder.Property(t => t.About).HasMaxLength(500);

            builder.HasData(
                new Teacher
                {
                    FirstName = "Osman",
                    LastName = "Kıran",
                    BirthYear = 1985,
                    About = "Uzun zamandır öğretmenlik yapıyorum ve öğretmeyi çok seviyorum.",
                    Gender = 'E',
                    Experience = 20,
                    Location = "İstanbul",
                    Url = "osman-kiran",
                    ImageUrl = "1.png",
                    DateOfRegistration = DateTime.Now,
                    PricePerHour = 1500,
                    BranchId = 1,
                    UniversityId=1
                },
                new Teacher
                {
                    FirstName = "Ahmet",
                    LastName = "Acar",
                    BirthYear = 1975,
                    About = "Uzun zamandır öğretmenlik yapıyorum ve öğretmeyi çok seviyorum.",
                    Gender = 'E',
                    Experience = 30,
                    Location = "Ankara",
                    Url = "ahmet-acar",
                    ImageUrl = "2.png",
                    DateOfRegistration = DateTime.Now,
                    PricePerHour = 2000,
                    BranchId = 2,
                    UniversityId = 2
                },
                new Teacher
                {
                    FirstName = "Hatice",
                    LastName = "Özer",
                    BirthYear = 1993,
                    About = "Uzun zamandır öğretmenlik yapıyorum ve öğretmeyi çok seviyorum.",
                    Gender = 'K',
                    Experience = 10,
                    Location = "İstanbul",
                    Url = "hatice-ozer",
                    ImageUrl = "3.png",
                    DateOfRegistration = DateTime.Now,
                    PricePerHour = 2500,
                    BranchId = 3,
                    UniversityId = 3
                },
                new Teacher
                {
                    FirstName = "Cemre",
                    LastName = "Şenel",
                    BirthYear = 1995,
                    About = "Uzun zamandır öğretmenlik yapıyorum ve öğretmeyi çok seviyorum.",
                    Gender = 'E',
                    Experience = 8,
                    Location = "İstanbul",
                    Url = "cemre-senel",
                    ImageUrl = "4.png",
                    DateOfRegistration = DateTime.Now,
                    PricePerHour = 2200,
                    BranchId = 1,
                    UniversityId = 4
                }
                );
        }
    }
}
