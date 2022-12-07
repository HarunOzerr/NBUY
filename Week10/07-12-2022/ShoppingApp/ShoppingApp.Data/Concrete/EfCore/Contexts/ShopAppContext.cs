using Microsoft.EntityFrameworkCore;
using ShoppingApp.Data.Config;
using ShoppingApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.Data.Concrete.EfCore.Contexts
{
    public class ShopAppContext : DbContext
    {
        public DbSet<Category> Categories { get; set; } //Eğer default ayarını değiştirmezsek, uygulamada bu isim ile çağıracağız ve veri tabanında da bu isim(Categories) ile oluşmuş olacak.
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; } //Yazmak zorunda değiliz EfCore bu tablodan zaten ilişkiyi kurup algılıyor. Biz yazıyoruz çünkü uygulamadan çağırmak istediğimizde buradan çağıracağız.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=ShoppingApp.db"); //Sqlite için DataBase'imize isim verdiğimiz yer. 'db' uzantısı verme sebebimiz windows üzerinden açarken otomatik olarak neyle açacağını belirtmemize yarıyor.
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Configuration'larımızı burada uyguluyoruz.
            modelBuilder.ApplyConfiguration(new CategoryConfig());
            modelBuilder.ApplyConfiguration(new ProductConfig());
            modelBuilder.ApplyConfiguration(new ProductCategoryConfig());
        }

    }
}
