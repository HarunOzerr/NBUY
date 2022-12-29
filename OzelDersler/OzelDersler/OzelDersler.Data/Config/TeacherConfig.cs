using OzelDersler.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace OzelDersler.Data.Config
{
    public class TeacherConfig : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Id).ValueGeneratedOnAdd();

            builder.Property(t => t.FirstName).IsRequired();
            builder.Property(t => t.FirstName).HasMaxLength(50);
            builder.Property(t => t.LastName).IsRequired();
            builder.Property(t => t.LastName).HasMaxLength(50);
        }
    }
}
