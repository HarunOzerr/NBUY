using OzelDersler.Entity.Concrete.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OzelDersler.Data.Abstract
{
    public interface IUserRepository : IRepository<User>
    {
        List<User> GetUsersByRole();

    }
}
