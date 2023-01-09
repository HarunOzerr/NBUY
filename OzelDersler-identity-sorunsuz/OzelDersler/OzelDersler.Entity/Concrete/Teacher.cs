using OzelDersler.Entity.Concrete.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OzelDersler.Entity.Concrete
{
    public class Teacher : BaseUserEntity
    {
        public int BranchId { get; set; }
        public Branch Branch { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
        public bool IsHome { get; set; }
        public int Age { get; set; }
        public int PricePerHour { get; set; }
        public int Experience { get; set; }
        public string About { get; set; }



    }
}
