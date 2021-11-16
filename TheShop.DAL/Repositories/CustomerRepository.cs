using System;
using System.Threading.Tasks;
using TheShop.Core.Entities;
using TheShop.DAL.Repositories.Intefaces;

namespace TheShop.DAL.Repositories
{
    public class CustomerRepository : IBaseRepository<Customer>
    {
        private readonly ShopContext context;

        public CustomerRepository(ShopContext shopContext)
        {
            context = shopContext;
        }

        public Task Add(Customer item)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task Delete(Customer item)
        {
            throw new NotImplementedException();
        }

        public Task Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(Customer item)
        {
            throw new NotImplementedException();
        }
    }
}
