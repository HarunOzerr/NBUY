using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.Data.Abstract
{
    public interface IRepository<T> //Bu interface dan miras alan class'ları kullanırken T yerine entity'mizi yazacağız.
    {
        Task<T> GetByIdAsync(int id); //ID'ye göre entity getirecek.
        Task<List<T>> GetAllAsync(); //T yerine belirtilen entity'deki ilgili tüm kayıtları getirecek.
        Task CreateAsync(T entity); //Yeni kayıt yaratacak
        void Update(T entity); //Kayıt güncelleyecek.
        void Delete(T entity); //Kayıt silecek.

    }
}
