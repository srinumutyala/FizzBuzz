using FactorialLibrary;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactorialLibrary
{
	public class FactorialService : IFactorialService
	{
		private readonly ILogger<FactorialService> _logger;
		public FactorialService(ILogger<FactorialService> logger)
		{
			_logger = logger;
		}

		public int FindFactorial(int number)
		{
			if (number <= 0)
			{
				_logger.LogError("Invaid number");
				throw new Exception($"Invaid input number {number}");
			}

			if (number >= 2) return number * FindFactorial(number - 1);
			return 1;
		}
	}
}
