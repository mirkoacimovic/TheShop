using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheShop.Core.Entities;

namespace TheShop.DAL
{
    public class ShopDbInitializer : CreateDatabaseIfNotExists<ShopContext>
    {
        protected override void Seed(ShopContext context)
        {
            // seed customers
            IList<Customer> customers = new List<Customer>();

            customers.Add(new Customer { Id = 1, Firstname = "Joe", Lastname = "Kawasaki", Address = "ABC Street 78", Balance = 320.83 });
            customers.Add(new Customer { Id = 2, Firstname = "Jane", Lastname = "Guilliati", Address = "Park Av Street 89", Balance = 1420.83 });

            context.Customers.AddRange(customers);

            // seed articles
            IList<Article> articles = new List<Article>();

            articles.Add(new Article { Id = 1, Name = "Jin Xui Mobile Phone XR5", Price = 120.99 });
            articles.Add(new Article { Id = 2, Name = "Koala Cola 2l", Price = 1.99 });
            articles.Add(new Article { Id = 3, Name = "Empty book", Price = 20.99 });
            articles.Add(new Article { Id = 4, Name = "Broken speakers 10W", Price = 2.99 });
            articles.Add(new Article { Id = 5, Name = "Dirty socks", Price = 4.99 });
            articles.Add(new Article { Id = 6, Name = "Yu noodles", Price = 3.99 });
            articles.Add(new Article { Id = 7, Name = "Glass half liter", Price = 7.99 });
            articles.Add(new Article { Id = 8, Name = "Commodore 64", Price = 300.99 });
            articles.Add(new Article { Id = 9, Name = "Virtual tetris", Price = 10.99 });
            articles.Add(new Article { Id = 10, Name = "Used slippers", Price = 5.99 });

            context.Articles.AddRange(articles);

            // seed providers
            IList<Supplier> providers = new List<Supplier>();

            var shikamotoSales = new Supplier() { Id = 1, Name = "If you get lost shop", Address = "Unknown" };
            shikamotoSales.Articles.Add(articles[0]);
            shikamotoSales.Articles.Add(articles[1]);
            shikamotoSales.Articles.Add(articles[3]);
            shikamotoSales.Articles.Add(articles[8]);

            providers.Add(shikamotoSales);

            var cornerDealers = new Supplier() { Id = 1, Name = "Corner Inc.", Address = "67 Corner Ave" };
            cornerDealers.Articles.Add(articles[9]);
            cornerDealers.Articles.Add(articles[1]);
            cornerDealers.Articles.Add(articles[8]);
            cornerDealers.Articles.Add(articles[2]);
            cornerDealers.Articles.Add(articles[4]);
            cornerDealers.Articles.Add(articles[8]);

            providers.Add(cornerDealers);

            context.Suppliers.AddRange(providers);

            base.Seed(context);
        }
    }
}
