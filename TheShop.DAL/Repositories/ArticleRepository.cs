using System;
using System.Threading.Tasks;
using TheShop.Core.Entities;
using TheShop.DAL.Repositories.Intefaces;

namespace TheShop.DAL.Repositories
{
    public class ArticleRepository : IBaseRepository<Article>
    {
        private readonly ShopContext context;

        public ArticleRepository(ShopContext shopContext)
        {
            context = shopContext;
        }

        public Task Add(Article item)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task Delete(Article item)
        {
            throw new NotImplementedException();
        }

        public Task Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(Article item)
        {
            throw new NotImplementedException();
        }
    }
}
