using OzelDersler.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OzelDersler.Entity.Concrete
{
    public class Student : IEntityBase
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Url { get; set; }
        public DateTime DateOfRegistration { get; set; } = DateTime.Now;
        public string About { get; set; }
        List<StudentTeacher> StudentTeachers { get; set; }
    }
}
