using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheShop.Core.DTO;
using TheShop.Core.Entities;

namespace TheShop.Services.Interfaces
{
    public interface IOrderService
    {
        Task<Order> GetOrder(int id);
        Task<bool> MakeOrder(ClientOrder clientOrder);
    }
}
