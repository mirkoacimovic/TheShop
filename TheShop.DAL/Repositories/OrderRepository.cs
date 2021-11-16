using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheShop.Core.Entities;
using TheShop.DAL.Repositories.Intefaces;

namespace TheShop.DAL.Repositories
{
    public class OrderRepository : IBaseRepository<Order>
    {
        private readonly ShopContext shopContext;

        public OrderRepository(ShopContext context)
        {
            shopContext = context;
        }

        public Task Add(Order item)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task Delete(Order item)
        {
            throw new NotImplementedException();
        }

        public Task Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(Order item)
        {
            throw new NotImplementedException();
        }
    }
}
