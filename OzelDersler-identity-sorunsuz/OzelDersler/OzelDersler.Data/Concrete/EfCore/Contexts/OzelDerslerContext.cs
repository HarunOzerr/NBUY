using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OzelDersler.Data.Config;
using OzelDersler.Data.Extensions;
using OzelDersler.Entity.Concrete;
using OzelDersler.Entity.Concrete.Identity;
using OzelDersYerim.Data.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OzelDersler.Data.Concrete.EfCore.Contexts
{
    public class OzelDerslerContext : IdentityDbContext<User, Role, string>
    {
        public OzelDerslerContext(DbContextOptions<OzelDerslerContext> options) : base(options)
        {

        }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<TeacherBranch> TeacherBranches { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.SeedData();
            modelBuilder.ApplyConfiguration(new StudentConfig());
            modelBuilder.ApplyConfiguration(new TeacherConfig());
            modelBuilder.ApplyConfiguration(new BranchConfig());
            modelBuilder.ApplyConfiguration(new TeacherBranchConfig());
            base.OnModelCreating(modelBuilder);
        }
    }
}
