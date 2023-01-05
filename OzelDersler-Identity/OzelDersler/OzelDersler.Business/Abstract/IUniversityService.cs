using OzelDersler.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OzelDersler.Business.Abstract
{
    public interface IUniversityService
    {
        Task<University> GetByIdAsync(int id);
        Task<List<University>> GetAllAsync();
        Task CreateAsync(University university);
        void Update(University university);
        void Delete(University university);
    }
}
