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
    public class StudentConfig : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(s => s.Id);
            builder.Property(s => s.Id).ValueGeneratedOnAdd();

            builder.Property(s => s.FirstName)
                .IsRequired()
                .HasMaxLength(35);

            builder.Property(s => s.LastName)
                .IsRequired()
                .HasMaxLength(35);

            builder.Property(s => s.Url).HasMaxLength(100);

            builder.Property(s => s.About)
                .IsRequired()
                .HasMaxLength(500);

            builder.HasData(
                new Student
                {
                    FirstName = "Harun",
                    LastName = "Özer",
                    About = "Matematik dersinde kendimi geliştirmek istiyorum.",
                    Url = "harun-ozer",
                    DateOfRegistration = DateTime.Now
                },
                new Student
                {
                    FirstName = "Selami",
                    LastName = "Sadak",
                    About = "Fizik dersinde kendimi geliştirmek istiyorum.",
                    Url = "selami-sadak",
                    DateOfRegistration = DateTime.Now
                },
                new Student
                {
                    FirstName = "Yavuz",
                    LastName = "Akduman",
                    About = "Biyoloji alanında kendimi geliştirmek istiyorum.",
                    Url = "yavuz-akduman",
                    DateOfRegistration = DateTime.Now
                }
                );
        }
    }
}
