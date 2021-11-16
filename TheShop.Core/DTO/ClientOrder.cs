using TheShop.Core.Entities;
using TheShop.Core.Enums;

namespace TheShop.Core.DTO
{
    public class ClientOrder
    {
        public int Id { get; set; }
        public Customer Customer { get; set; }
        public Article Article { get; set; }
        public OrderType OrderType { get; set; }
        public double CustomerOrderPrice { get; set; }
    }
}
