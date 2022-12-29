using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OzelDersler.Entity.Concrete
{
    public class Teacher
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string About { get; set; }
        public char Gender { get; set; }
        public int Experience { get; set; }
        public string Location { get; set; }
        public string Url { get; set; }
        public DateTime DateOfRegistration { get; set; } = DateTime.Now;
        public decimal PricePerHour { get; set; }
        public int BranchId { get; set; }
        public Branch Branch { get; set; }
        public int UniversityId { get; set; }
        public University University { get; set; }
        public List<StudentTeacher> StudentTeachers { get; set; }
    }
}
