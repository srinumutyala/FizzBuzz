using FactorialLibrary;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using Microsoft.Extensions.Logging.Console;

namespace FactorialConsole
{
	class Program
	{
        static void Main(string[] args)
		{
			//setup our DI
			ServiceProvider serviceProvider;
			ILogger<Program> logger;
			SetLoggerAndDependencies(out serviceProvider, out logger);

			Console.Write("Enter a number and press Enter Key>");

			var number = Console.ReadLine();
			int.TryParse(number, out int resultNumber);
			try
			{

				if (resultNumber! < 0)
					Console.WriteLine("Please enter a valid number");

				var factorialService = serviceProvider.GetService<IFactorialService>();
				var factorial = factorialService.FindFactorial(resultNumber);
				Console.WriteLine($"Factorial for the {resultNumber} is :{factorial}");
			}
			catch(Exception ex)
			{
				logger.LogError($"There was an issue : {ex.Message}, please contact administrator!");
			}

			Console.WriteLine("Enter any key to exit");

			Console.Read();
		}

		private static void SetLoggerAndDependencies(out ServiceProvider serviceProvider, out ILogger<Program> logger)
		{
			serviceProvider = new ServiceCollection()
				 .AddLogging(c => c.AddConsole(opt => opt.LogToStandardErrorThreshold = LogLevel.Debug))
				.AddSingleton<IFactorialService, FactorialService>()
				.BuildServiceProvider();
			logger = serviceProvider.GetService<ILoggerFactory>()
				.CreateLogger<Program>();
		}
	}
}
