using System.Threading.Tasks;
using TheShop.Core.Entities;

namespace TheShop.Services.Interfaces
{
    public interface ISupplierService
    {
        Task<Article> GetArticle(Article article);
        Task<bool> CheckInventory(Article article);
    }
}
