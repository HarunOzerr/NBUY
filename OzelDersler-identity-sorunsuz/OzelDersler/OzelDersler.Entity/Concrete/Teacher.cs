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
        public string Branch { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }


    }
}
