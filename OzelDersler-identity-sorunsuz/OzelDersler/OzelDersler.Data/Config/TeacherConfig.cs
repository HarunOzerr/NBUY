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
    public class TeacherConfig : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> builder)
        {
            builder.HasData
                (
                    new Teacher
                    {
                        Id = 1,
                        FirstName = "Mert",
                        LastName = "Muslu",
                        BranchId = 1,
                        City = "İstanbul",
                        Address = "Esenler",
                        Gender = "Erkek",
                        ImageUrl = "mert.png",
                        Job = "Developer",
                        Age = 24,
                        IsHome = true,
                        About = "Şuanda Wissen Akademie'de yazılım kursundayım. Matematik alanında ders veriyorum.",
                        Experience = 5,
                        PricePerHour = 350,
                        UserId = "teacher"
                    }
                );
        }
    }
}
