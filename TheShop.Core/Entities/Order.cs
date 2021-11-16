using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheShop.Core.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public Customer Buyer { get; set; }
        public Supplier Seller { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
