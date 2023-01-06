using OzelDersler.Entity.Concrete;
using OzelDersler.Entity.Concrete.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OzelDersler.Business.Abstract
{
    public interface IUserService
    {
        Task<User> GetByIdAsync(int id);
        Task<List<User>> GettAllAsync();
        Task CreateAsync(User user);
        void Update(User user);
        void Delete(User user);
        List<User> GetUsersByRole();
    }
}
