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
    public class EfCoreTeacherRepository : EfCoreGenericRepository<Teacher>, ITeacherRepository
    {
        public EfCoreTeacherRepository(OzelDerslerContext context) : base(context)
        {

        }
        private OzelDerslerContext OzelDerslerContext
        {
            get { return _context as OzelDerslerContext; }
        }
        public Task<List<Teacher>> GetHomePageTeachersAsync()
        {
            throw new NotImplementedException();
        }

        public List<Teacher> GetTeachersByBranch()
        {
            throw new NotImplementedException();
        }
    }
}
