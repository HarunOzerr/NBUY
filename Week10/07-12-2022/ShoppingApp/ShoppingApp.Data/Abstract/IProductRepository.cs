using ShoppingApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.Data.Abstract
{
    public interface IProductRepository :IRepository<Product>
    {
        //Product'a özgü memberlar burada olacak.(property, field, method...)
        //Örneğin aşağıdakiler gibi:
        List<Product> GetProductsByCategory();
        Task<List<Product>> GetHomePageProductsAsync();
    }
}
