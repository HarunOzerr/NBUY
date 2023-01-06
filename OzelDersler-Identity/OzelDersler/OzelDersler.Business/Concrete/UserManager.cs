using OzelDersler.Business.Abstract;
using OzelDersler.Data.Abstract;
using OzelDersler.Entity.Concrete.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OzelDersler.Business.Concrete
{
    public class UserManager : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;

        public UserManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task CreateAsync(User user)
        {
            await _unitOfWork.Users.CreateAsync(user);
            await _unitOfWork.SaveAsync();
        }

        public void Delete(User user)
        {
            _unitOfWork.Users.Delete(user);
            _unitOfWork.Save();
        }

        public async Task<User> GetByIdAsync(int id)
        {
            return await _unitOfWork.Users.GetByIdAsync(id);
        }

        public async Task<List<User>> GettAllAsync()
        {
            return await _unitOfWork.Users.GetAllAsync();
        }

        public List<User> GetUsersByRole()
        {
            throw new NotImplementedException();
        }

        public void Update(User user)
        {
            _unitOfWork.Users.Update(user);
            _unitOfWork.Save();
        }
    }
}
