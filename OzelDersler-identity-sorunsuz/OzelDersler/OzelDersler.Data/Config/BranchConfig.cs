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
    public class BranchConfig : IEntityTypeConfiguration<Branch>
    {
        public void Configure(EntityTypeBuilder<Branch> builder)
        {
            builder.HasKey(b => b.Id);
            builder.Property(b => b.Id).ValueGeneratedOnAdd();

            builder.Property(b => b.Name).IsRequired();
            builder.Property(b => b.Name).HasMaxLength(50);

            builder.Property(b => b.Url).HasMaxLength(50);


            builder.HasData(
                new Branch
                {
                    Id = 1,
                    Name= "Matematik",
                    Url = "matematik"
                },
                new Branch
                {
                    Id = 2,
                    Name = "Fizik",
                    Url = "fizik"
                },
                new Branch
                {
                    Id = 3,
                    Name = "Kimya",
                    Url = "kimya"
                },
                new Branch
                {
                    Id = 4,
                    Name = "Biyoloji",
                    Url = "biyoloji"
                }
                );
        }
    }
}
