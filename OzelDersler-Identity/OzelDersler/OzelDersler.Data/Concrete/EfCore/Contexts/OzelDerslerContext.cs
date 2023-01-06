using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OzelDersler.Data.Config;
using OzelDersler.Data.Extensions;
using OzelDersler.Entity.Concrete;
using OzelDersler.Entity.Concrete.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OzelDersler.Data.Concrete.EfCore.Contexts
{
    public class OzelDerslerContext : IdentityDbContext<User, Role, string>
    {
        public DbSet<Branch> Branches { get; set; }

        public OzelDerslerContext(DbContextOptions<OzelDerslerContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.SeedData();
            modelBuilder.ApplyConfiguration(new BranchConfig());
            base.OnModelCreating(modelBuilder);
        }
    }
}
