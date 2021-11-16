using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheShop.Core.Entities;
using TheShop.DAL.Repositories.Intefaces;

namespace TheShop.DAL.Repositories
{
    public class SupplierRepository : IBaseRepository<Supplier>
    {
        private readonly ShopContext shopContext;

        public SupplierRepository()
        {
            if(shopContext == null)
            {
                shopContext = new ShopContext();
            }
        }

        public Task Add(Supplier item)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task Delete(Supplier item)
        {
            throw new NotImplementedException();
        }

        public Task Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Supplier>> GetByArticle(Article article)
        {
            return Task.FromResult(shopContext.Suppliers.Include("Articles").Where(a => a.Articles.Contains(article)).ToList());
        }

        public Task Update(Supplier item)
        {
            throw new NotImplementedException();
        }
    }
}
