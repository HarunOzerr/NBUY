using OzelDersler.Business.Abstract;
using OzelDersler.Data.Abstract;
using OzelDersler.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OzelDersler.Business.Concrete
{
    public class UniversityManager : IUniversityService
    {
        private readonly IUnitOfWork _unitOfWork;

        public UniversityManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task CreateAsync(University university)
        {
            await _unitOfWork.Universities.CreateAsync(university);
            await _unitOfWork.SaveAsync();
        }

        public void Delete(University university)
        {
            _unitOfWork.Universities.Delete(university);
            _unitOfWork.Save();
        }

        public async Task<List<University>> GetAllAsync()
        {
            return await _unitOfWork.Universities.GetAllAsync();
        }

        public async Task<University> GetByIdAsync(int id)
        {
            return await _unitOfWork.Universities.GetByIdAsync(id);
        }

        public void Update(University university)
        {
            _unitOfWork.Universities.Update(university);
            _unitOfWork.Save();
        }
    }
}
