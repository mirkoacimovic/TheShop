using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheShop.DAL.Repositories
{
    public class ShopUnitOfWork<T> where T : class
    {
        private ShopContext shopContext;
        private CustomerRepository customerRepository;
        private ArticleRepository articleRepository;
        private SupplierRepository providerRepository;
        private OrderRepository purchaseRepository;

        public ShopUnitOfWork(ShopContext context)
        {
            shopContext = context;
        }

        public void Save()
        {
            shopContext.SaveChanges();
        }

        public CustomerRepository GetCustomerRepository 
        { 
            get 
            {
                if(customerRepository == null)
                {
                    return new CustomerRepository(shopContext);
                }

                return customerRepository;
            } 
        }

        public ArticleRepository GetArticleRepository
        {
            get
            {
                if (articleRepository == null)
                {
                    return new ArticleRepository(shopContext);
                }

                return articleRepository;
            }
        }

        public SupplierRepository GetProviderRepository
        {
            get
            {
                if (providerRepository == null)
                {
                    return new SupplierRepository(shopContext);
                }

                return providerRepository;
            }
        }

        public OrderRepository GetPurchaseRepository
        {
            get
            {
                if (purchaseRepository == null)
                {
                    return new OrderRepository(shopContext);
                }

                return purchaseRepository;
            }
        }
    }
}
