using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheShop.Core.Entities;

namespace TheShop.DAL
{
    public class ShopContext : DbContext
    {
        public ShopContext() : base()
        {
            Database.SetInitializer(new ShopDbInitializer());
        }

        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Order> Orders { get; set; }

    }
}
