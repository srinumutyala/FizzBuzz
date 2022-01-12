using FactorialLibrary;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FactorialLibrary
{
	/// <summary>
	/// Class that implements the IFactorialService <see cref="IFactorialService"/>
	/// </summary>
	public class FactorialService : IFactorialService
	{
		private readonly ILogger<FactorialService> _logger;
		public FactorialService(ILogger<FactorialService> logger)
		{
			_logger = logger;
		}

		/// <summary>
		/// Method that computes the factorial for the given number
		/// </summary>
		/// <param name="number"></param>
		/// <returns></returns>
		public async Task<int> FindFactorial(int number)
		{
			if (number <= 0)
			{
				_logger.LogError("Invaid number");
				throw new Exception($"Invaid input number {number}");
			}

			if (number >= 2) return number * await FindFactorial(number - 1);

			return await Task.FromResult(1);
		}
	}
}
