using System;
using System.Threading.Tasks;
using TheShop.Core.Enums;
using TheShop.Core.DTO;
using TheShop.Core.Entities;
using TheShop.Services.Interfaces;

namespace TheShop.Services
{
    public class OrderService : IOrderService
    {
        private readonly ISupplierService supplyService;

        public OrderService(ISupplierService supplierService)
        {
            supplyService = supplierService;
        }

        public Task<Order> GetOrder(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> MakeOrder(ClientOrder clientOrder)
        {
            // buy or sell
            if(clientOrder.OrderType == OrderType.BUY)
            {
                var article = await supplyService.GetArticle(clientOrder.Article);
            }
            else
            {
                // sell item
            }

            return true;
        }
    }
}
