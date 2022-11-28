using BlogApp.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Data.Concrete.EntityFramework.Mappings
{
    public class ArticleMap : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            #region Açıklama1
            //Burada EF Core tarafından default convention yöntemiyle kendiliğinden gerçekleşen bazı ayarları el ile yapıyor olacağız.
            //Bu daha profosyonel sürdürülebilir, genişletilebilir uygulamalar yapmak için tercih edilen bir yoldur.
            #endregion

            builder.HasKey(a => a.Id); //Primary Key
            builder.Property(a => a.Id).ValueGeneratedOnAdd(); //Identity eklendikçe birer birer artış
            
            builder.Property(a => a.Title).IsRequired(); //zorunlu(varsayılanı true yani zorunlu)
            builder.Property(a => a.Title).HasMaxLength(100); //Max 100 karakter
        
            builder.Property(c => c.Content).IsRequired();
            builder.Property(c => c.Content).HasColumnType("NVARCHAR(MAX)");

            builder.Property(t => t.Thumbnail).IsRequired();
            builder.Property(t => t.Thumbnail).HasMaxLength(250);

            builder.Property(d => d.Date).IsRequired();
        
            builder.Property(s => s.SeoAuthor).IsRequired();
            builder.Property(s => s.SeoAuthor).HasMaxLength(50);

            builder.Property(s => s.SeoDescription).IsRequired();
            builder.Property(s => s.SeoDescription).HasMaxLength(150);

            builder.Property(s => s.SeoTags).IsRequired();
            builder.Property(s => s.SeoTags).HasMaxLength(70);

            builder.Property(v => v.ViewsCount).IsRequired();

            builder.Property(c => c.CommentCount).IsRequired();

            builder.Property(c => c.CreatedByName).IsRequired();
            builder.Property(c => c.CreatedByName).HasMaxLength(70);

            builder.Property(m => m.ModifiedByName).IsRequired();
            builder.Property(m => m.ModifiedByName).HasMaxLength(50);

            builder.Property(c => c.CreatedDate).IsRequired();

            builder.Property(m => m.ModifiedDate).IsRequired();

            builder.Property(i => i.IsActive).IsRequired();

            builder.Property(n => n.Note).HasMaxLength(500);

            //Bire çok ilişkiyi bu şekilde tanımlıyoruz. İçerisindeki Foreign Key'i de tanımlamamız gerek.
            builder.HasOne(c => c.Category)
                .WithMany(a => a.Articles)
                .HasForeignKey(a => a.CategoryId);

            builder.HasOne(u => u.User) //Bir User'ın HasOne
                .WithMany(a => a.Articles) //Bir'den çok WithMany article'ı olabilir.
                .HasForeignKey(a => a.UserId);
            
            builder.ToTable("Articles"); //Tabloya farklı bir isim vermek için kullanıyoruz. Vermezsek otomatik olarak kendi isimlendiriyor.

            // İlk article verileri ekleniyor.
            builder.HasData(
                new Article()
                {
                    Id = 1,
                    CategoryId = 1,
                    UserId= 1,
                    Title = "C# 11.0 Yenilikleri",
                    Content = "Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alarak karıştırdığı 1500'lerden beri endüstri standardı sahte metinler olarak kullanılmıştır. Beşyüz yıl boyunca varlığını sürdürmekle kalmamış, aynı zamanda pek değişmeden elektronik dizgiye de sıçramıştır. 1960'larda Lorem Ipsum pasajları da içeren Letraset yapraklarının yayınlanması ile ve yakın zamanda Aldus PageMaker gibi Lorem Ipsum sürümleri içeren masaüstü yayıncılık yazılımları ile popüler olmuştur.",
                    Thumbnail = "default.jpg",
                    SeoDescription = "C# 11.0 Yenilikleri",
                    SeoTags = "C#, C# 11.0, DotNet 6, DotNet 7, DotNet Core",
                    SeoAuthor = "Deniz Gezen",
                    ViewsCount= 116,
                    CommentCount= 1,
                    Date =DateTime.Now,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreated",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreated",
                    ModifiedDate = DateTime.Now,
                    Note = "C# 11.0 Yenilikleri",
                },
                new Article()
                {
                    Id = 2,
                    CategoryId = 2,
                    UserId = 1,
                    Title = "Modern Javascript",
                    Content = "Yinelenen bir sayfa içeriğinin okuyucunun dikkatini dağıttığı bilinen bir gerçektir. Lorem Ipsum kullanmanın amacı, sürekli 'buraya metin gelecek, buraya metin gelecek' yazmaya kıyasla daha dengeli bir harf dağılımı sağlayarak okunurluğu artırmasıdır. Şu anda birçok masaüstü yayıncılık paketi ve web sayfa düzenleyicisi, varsayılan mıgır metinler olarak Lorem Ipsum kullanmaktadır. Ayrıca arama motorlarında 'lorem ipsum' anahtar sözcükleri ile arama yapıldığında henüz tasarım aşamasında olan çok sayıda site listelenir. Yıllar içinde, bazen kazara, bazen bilinçli olarak (örneğin mizah katılarak), çeşitli sürümleri geliştirilmiştir.",
                    Thumbnail = "default.jpg",
                    SeoDescription = "Modern Javascript",
                    SeoTags = "ECMA Script 6, map, filter, reduce, arrow, function",
                    SeoAuthor = "Deniz Gezen",
                    ViewsCount = 193,
                    CommentCount = 1,
                    Date = DateTime.Now,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreated",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreated",
                    ModifiedDate = DateTime.Now,
                    Note = "Modern Javascript",
                },
                new Article()
                {
                    Id = 3,
                    CategoryId = 3,
                    UserId = 2,
                    Title = "React Component Yapısı",
                    Content = "Lorem Ipsum pasajlarının birçok çeşitlemesi vardır. Ancak bunların büyük bir çoğunluğu mizah katılarak veya rastgele sözcükler eklenerek değiştirilmişlerdir. Eğer bir Lorem Ipsum pasajı kullanacaksanız, metin aralarına utandırıcı sözcükler gizlenmediğinden emin olmanız gerekir. İnternet'teki tüm Lorem Ipsum üreteçleri önceden belirlenmiş metin bloklarını yineler. Bu da, bu üreteci İnternet üzerindeki gerçek Lorem Ipsum üreteci yapar. Bu üreteç, 200'den fazla Latince sözcük ve onlara ait cümle yapılarını içeren bir sözlük kullanır. Bu nedenle, üretilen Lorem Ipsum metinleri yinelemelerden, mizahtan ve karakteristik olmayan sözcüklerden uzaktır.",
                    Thumbnail = "default.jpg",
                    SeoDescription = "React Component Yapısı",
                    SeoTags = "React, React Js, component, state, class component, function component",
                    SeoAuthor = "Yusuf Onan",
                    ViewsCount = 225,
                    CommentCount = 1,
                    Date = DateTime.Now,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreated",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreated",
                    ModifiedDate = DateTime.Now,
                    Note = "React Component Yapısı",
                }
                );
        }
    }
}
