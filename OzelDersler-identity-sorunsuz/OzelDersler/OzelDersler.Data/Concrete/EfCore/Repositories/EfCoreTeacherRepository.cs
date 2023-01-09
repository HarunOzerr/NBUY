using Microsoft.EntityFrameworkCore;
using OzelDersler.Data.Abstract;
using OzelDersler.Data.Concrete.EfCore.Contexts;
using OzelDersler.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OzelDersler.Data.Concrete.EfCore.Repositories
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
        public async Task<List<Teacher>> GetHomePageTeachersAsync()
        {
            return await OzelDerslerContext.Teachers.Where(t => t.IsHome == true).ToListAsync();
        }

        public async Task<List<Teacher>> GetTeachersByBranchAsync(int branchId)
        {
            var teachers = OzelDerslerContext.Teachers.AsQueryable();
                teachers = teachers
                    .Include(t => t.Branch)
                    .Where(t => t.BranchId == branchId);
            return await teachers.ToListAsync();
        }
    }
}
