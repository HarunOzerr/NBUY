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
    public class StudentTeacherConfig : IEntityTypeConfiguration<StudentTeacher>
    {
        public void Configure(EntityTypeBuilder<StudentTeacher> builder)
        {
            builder.HasKey(st => new { st.StudentId, st.TeacherId });

            builder.HasData(
                new StudentTeacher { StudentId = 1, TeacherId = 1 },
                new StudentTeacher { StudentId = 2, TeacherId = 1 },
                new StudentTeacher { StudentId = 1, TeacherId = 3 },
                new StudentTeacher { StudentId = 3, TeacherId = 2 }
                );
        }
    }
}
