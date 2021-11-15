using Autofac;
using System;
using TheShop.Services;

namespace TheShop
{
	internal class Program
	{
		private static IContainer ConfigureContainer()
		{
			var builder = new ContainerBuilder();

			builder.RegisterType<Application>().AsSelf();
			builder.RegisterType<LoggerService>().As<ILogger>();
			return builder.Build();
		}

		private static void Main(string[] args)
		{
			var container = ConfigureContainer();
			var app = container.Resolve<Application>();
			app.Run(args);

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