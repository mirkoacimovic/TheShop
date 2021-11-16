using Autofac;
using TheShop.DAL.Repositories;
using TheShop.Services;
using TheShop.Services.Interfaces;

namespace TheShop
{
    internal class Program
	{
		private static IContainer ConfigureContainer()
		{
			var builder = new ContainerBuilder();

			builder.RegisterType<Application>().AsSelf();
			builder.RegisterType<LoggerService>().As<ILogger>();
			builder.RegisterType<SupplierRepository>().AsSelf();
			builder.RegisterType<ArticleRepository>().AsSelf();
			builder.RegisterType<CustomerRepository>().AsSelf();
			builder.RegisterType<OrderRepository>().AsSelf();
			builder.RegisterType<OrderService>().As<IOrderService>();
			builder.RegisterType<SupplierService>().As<ISupplierService>();
			return builder.Build();
		}

		private static void Main(string[] args)
		{
			var container = ConfigureContainer();
			using (var scope = container.BeginLifetimeScope())
			{
				var app = container.Resolve<Application>();
				app.Run(args);
			}
		}
	}
}