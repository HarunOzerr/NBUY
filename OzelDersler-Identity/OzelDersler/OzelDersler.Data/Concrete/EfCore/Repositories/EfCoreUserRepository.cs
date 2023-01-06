using OzelDersler.Data.Abstract;
using OzelDersler.Data.Concrete.EfCore.Contexts;
using OzelDersler.Entity.Concrete.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OzelDersler.Data.Concrete.EfCore.Repositories
{
    public class EfCoreUserRepository : EfCoreGenericRepository<User>, IUserRepository
    {
        public EfCoreUserRepository(OzelDerslerContext context) : base(context)
        {

        }

        public List<User> GetUsersByRole()
        {
            throw new NotImplementedException();
        }
    }
}
