using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OzelDersler.Data.Abstract
{
    public interface IUnitOfWork : IDisposable
    {
        IBranchRepository Branches { get; }
        IUserRepository Users { get; }
        Task SaveAsync();
        void Save();
    }
}
