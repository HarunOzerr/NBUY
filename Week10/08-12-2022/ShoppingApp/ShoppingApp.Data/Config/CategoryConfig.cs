using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShoppingApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.Data.Config
{
    public class CategoryConfig : IEntityTypeConfiguration<Category> //Configuration işlemleri için miras aldığımız Interface
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(c => c.Id); //Primary key belirtmek için 'HasKey' kullanıyoruz. Entity'leri tanımlarken Id olarak tanımladığımızda EfCore kendisi de primary key olduğunu anlıyor ve tanımlıyor.
            builder.Property(c => c.Id).ValueGeneratedOnAdd(); //1'den başlayarak otomatik olarak artacak.
            builder.Property(c => c.Name).IsRequired(); //Category'nin Name'inin veritabanında zorunlu olacağı özelliğini veriyoruz.
            builder.Property(c => c.Name).HasMaxLength(50); //Max uzunluğunun 50 karakter olacağını belirttik.

            builder.Property(c => c.Description)
                .IsRequired()
                .HasMaxLength(500); //Bu şekilde satırı bitirmeden .(nokta) ile devam ederekte yazabiliyoruz.

            builder.Property(c => c.Url)
                .IsRequired()
                .HasMaxLength(500);

            builder.ToTable("Categories"); //Tablonun oluşacak ismini bu şekilde belirtebiliyoruz.

            builder.HasData( //Başlangıç verisi olarak veri girişi yapıyoruz.
                new Category{Id = 1, Name = "Telefon", Description = "Telefonlar bu kategoride bulunmaktadır.", Url = "telefon"}, //Bu şekilde tek satırda da yazılır.
                new Category
                {   //Bu şekilde alt altada.
                    Id = 2,
                    Name = "Elektronik",
                    Description = "Elektronik ürünler bu kategoride bulunmaktadır.",
                    Url = "elektronik"
                },
                new Category{Id = 3, Name = "Bilgisayar", Description = "Bilgisayarlar bu kategoride bulunmaktadır.", Url = "bilgisayar"},
                new Category{Id = 4, Name = "Beyaz Eşya", Description = "Beyaz Eşyalar bu kategoride bulunmaktadır.", Url = "beyaz-esya"}
                );
        }
    }
}
