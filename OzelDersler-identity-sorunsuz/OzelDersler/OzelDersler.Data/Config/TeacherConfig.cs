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
                        ImageUrl = "10.png",
                        Job = "Developer",
                        Age = 24,
                        IsHome = true,
                        About = "Şuanda Wissen Akademie'de yazılım kursundayım. Matematik alanında ders veriyorum.",
                        Experience = 5,
                        PricePerHour = 350,
                        UserId = "teacher"
                    },
                    new Teacher
                    {
                        Id = 2,
                        FirstName = "Gonca",
                        LastName = "Özer",
                        BranchId = 4,
                        City = "İstanbul",
                        Address = "Başakşehir",
                        Gender = "Kadın",
                        ImageUrl = "11.png",
                        Job = "Almanca Öğretmeni",
                        Age = 24,
                        IsHome = true,
                        About = "Müziğe ilgi duyuyorum. Müzikle birlikte yabancı dillerin de öğrenilebileceğine inanıyorum.",
                        Experience = 2,
                        PricePerHour = 500,
                        UserId = "teacher1"
                    },
                    new Teacher
                    {
                        Id = 3,
                        FirstName = "Hatice",
                        LastName = "Durmuş",
                        BranchId = 2,
                        City = "İstanbul",
                        Address = "Göztepe",
                        Gender = "Kadın",
                        ImageUrl = "11.png",
                        Job = "Sınıf Öğretmeni",
                        Age = 30,
                        IsHome = true,
                        About = "Sınıf öğretmenliği yapıyorum. Öğrencilerimi eğitmeyi ve onlara bir şeyler katmayı seviyorum.",
                        Experience = 8,
                        PricePerHour = 500,
                        UserId = "teacher2"
                    },
                    new Teacher
                    {
                        Id = 4,
                        FirstName = "Ahmet",
                        LastName = "Yılmaz",
                        BranchId = 3,
                        City = "İstanbul",
                        Address = "Kartal",
                        Gender = "Erkek",
                        ImageUrl = "10.png",
                        Job = "İngilizce Tecrümanı",
                        Age = 45,
                        IsHome = true,
                        About = "Aktif olarak ingilizce tercümanlığı ile meşgulüm. Senelerdir ingilizce alanınca tezler ve çeviriler hazırlıyorum. Öğrencilerime her seviyede ingilizce eğitimi verebilirim.",
                        Experience = 20,
                        PricePerHour = 900,
                        UserId = "teacher3"
                    },
                    new Teacher
                    {
                        Id = 5,
                        FirstName = "David",
                        LastName = "Dark",
                        BranchId = 4,
                        City = "Ankara",
                        Address = "Çağlayan",
                        Gender = "Erkek",
                        ImageUrl = "10.png",
                        Job = "Müzik Öğretmeni",
                        Age = 33,
                        IsHome = true,
                        About = "Yurtdışında gördüğüm müzik eğitimiyle birlikte türkiyede aktif olarak öğretmenlik yapmaktayım. Çeşitli organizasyonlarda ve yarışmalarda başarılarım bulunmakta. Ses eğitimi ve müzik bilgisi alanında öğrencilerimi ileri seviyeye taşımak için elimden geleni yapmaktayım.",
                        Experience = 10,
                        PricePerHour = 600,
                        UserId = "teacher4"
                    }
                );
        }
    }
}
