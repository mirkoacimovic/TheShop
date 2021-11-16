using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheShop.Core.Entities;
using TheShop.Services.Interfaces;
using TheShop.DAL.Repositories;

namespace TheShop.Services
{
    public class SupplierService : ISupplierService
    {
        private readonly SupplierRepository supplierRepository;

        public SupplierService(SupplierRepository supplierRepository)
        {
            this.supplierRepository = supplierRepository;
        }

        public Task<bool> CheckInventory(Article article)
        {
            var a = supplierRepository.GetByArticle(article);

            return null;
        }

        public Task<Article> GetArticle(Article article)
        {
            // check inventory

            // check price

            // return article

            throw new NotImplementedException();
        }
    }
}
