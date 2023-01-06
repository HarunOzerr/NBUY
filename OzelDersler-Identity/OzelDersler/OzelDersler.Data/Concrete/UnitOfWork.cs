using OzelDersler.Data.Abstract;
using OzelDersler.Data.Concrete.EfCore.Contexts;
using OzelDersler.Data.Concrete.EfCore.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OzelDersler.Data.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly OzelDerslerContext _context;

        public UnitOfWork(OzelDerslerContext context)
        {
            _context = context;
        }

        private EfCoreBranchRepository _branchRepsitory;
        private EfCoreUserRepository _userRepository;


        public IBranchRepository Branches => _branchRepsitory = _branchRepsitory ?? new EfCoreBranchRepository(_context);
        public IUserRepository Users => _userRepository = _userRepository ?? new EfCoreUserRepository(_context);


        public void Dispose()
        {
            _context.Dispose();
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
