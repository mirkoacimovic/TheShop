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
		}
	}
}