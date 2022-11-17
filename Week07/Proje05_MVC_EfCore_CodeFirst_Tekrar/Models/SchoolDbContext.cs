using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Proje05_MVC_EfCore_CodeFirst_Tekrar.Models
{
    public class SchoolDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Bolum> Bolums { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = School.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
            .HasData(
                new Student(){Id = 1, Name = "Mert", Yas = 23},
                new Student(){Id = 2, Name = "Osman", Yas = 17},
                new Student(){Id = 3, Name = "Mehmet", Yas = 21},
                new Student(){Id = 4, Name = "Kerem", Yas = 22}
            );
            modelBuilder.Entity<Bolum>()
            .HasData(
                new Bolum(){Id = 1, Name = "Matematik"},
                new Bolum(){Id = 2, Name = "Türkçe"},
                new Bolum(){Id = 3, Name = "Fizik"},
                new Bolum(){Id = 4, Name = "Kimya"}
            );
            modelBuilder.Entity<Teacher>()
            .HasData(
                new Teacher(){Id = 1, Name = "Selami", Yas = 45, BolumId = 4},
                new Teacher(){Id = 2, Name = "Yasin", Yas = 54, BolumId = 3},
                new Teacher(){Id = 3, Name = "Doğan", Yas = 28, BolumId = 1},
                new Teacher(){Id = 4, Name = "Mahmut", Yas = 37, BolumId = 2},
                new Teacher(){Id = 5, Name = "Aysel", Yas = 33, BolumId = 1}
            );
        }
    }
}