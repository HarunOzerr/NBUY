using Microsoft.EntityFrameworkCore;
using ShoppingApp.Data.Abstract;
using ShoppingApp.Data.Concrete.EfCore.Contexts;
using ShoppingApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.Data.Concrete.EfCore.Repositories
{
    public class EfCoreOrderRepository : EfCoreGenericRepository<Order>, IOrderRepository
    {
        public EfCoreOrderRepository(ShopAppContext context) : base(context)
        {

        }
        private ShopAppContext ShopAppContext
        {
            get { return _context as ShopAppContext; }
        }
        public async Task<List<Order>> GetOrders(string userId)
        {
            #region UserIdNullKontrolüYapılmadan
            //var orders = ShopAppContext.Order
            //    .Where(o => o.UserId == userId)
            //    .Include(o => o.OrderItems)
            //    .ThenInclude(oi => oi.Product)
            //    .ToList();

            //return orders;
            #endregion
            #region UserIdNullKontrolüYaparak
            var orders = ShopAppContext.Order
                .Include(o => o.OrderItems)
                .ThenInclude(oi => oi.Product)
                .AsQueryable(); //Sorguyu çalıştırma benim kontrolümden sonra sorgumu ekleyince işlem yap.
            if (!String.IsNullOrEmpty(userId))
            {
                orders = orders.Where(o => o.UserId == userId); //Eğer id null gelmediyse karşılaştır.
            }
            return orders.ToList();//Listeleyip geri döndür.
            #endregion

        }
    }
}
