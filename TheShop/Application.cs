using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheShop.Core.Entities;
using TheShop.Services;
using TheShop.Services.Interfaces;

namespace TheShop
{
    public class Application
    {
        private readonly ISupplierService supplierService;

        public Application(ISupplierService supplierService)
        {
            this.supplierService = supplierService;
            // TODO: Inject all services needed
        }

        public void Run(string[] args)
        {
			Console.WriteLine("Started...");

			supplierService.CheckInventory(null);
          
			Console.ReadLine();

			//var shopService = new ShopService();

			//try
			//{
			//	//order and sell
			//	shopService.OrderAndSellArticle(1, 20, 10);
			//}
			//catch (Exception ex)
			//{
			//	Console.WriteLine(ex);
			//}

			//try
			//{
			//	//print article on console
			//	var article = shopService.GetById(1);
			//	Console.WriteLine("Found article with ID: " + article.ID);
			//}
			//catch (Exception ex)
			//{
			//	Console.WriteLine("Article not found: " + ex);
			//}

			//try
			//{
			//	//print article on console				
			//	var article = shopService.GetById(12);
			//	Console.WriteLine("Found article with ID: " + article.ID);
			//}
			//catch (Exception ex)
			//{
			//	Console.WriteLine("Article not found: " + ex);
			//}

			//Console.ReadKey();
		}
	}
}
