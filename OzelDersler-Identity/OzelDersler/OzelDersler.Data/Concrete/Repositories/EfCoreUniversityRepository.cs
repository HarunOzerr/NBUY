using OzelDersler.Data.Abstract;
using OzelDersler.Data.Concrete.EfCore.Contexts;
using OzelDersler.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OzelDersler.Data.Concrete.Repositories
{
    public class EfCoreUniversityRepository : EfCoreGenericRepository<University>, IUniversityRepository
    {
        public EfCoreUniversityRepository(OzelDerslerContext context) : base(context)
        {

        }
    }
}
