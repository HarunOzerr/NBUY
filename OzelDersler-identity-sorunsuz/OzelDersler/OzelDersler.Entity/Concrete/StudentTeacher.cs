using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OzelDersler.Entity.Concrete
{
    public class StudentTeacher
    {
        public string StudentId { get; set; }
        public Student Student { get; set; }
        public string TeacherId { get; set; }
        public Teacher Teacher { get; set; }

    }
}
