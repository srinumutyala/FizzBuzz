using FactorialLibrary;
using Microsoft.Extensions.Logging;
using Moq;
using System;
using System.Threading.Tasks;
using Xunit;

namespace FactorialTests
{
	public class FactorialServiceTests
	{

		private Mock<ILogger<FactorialService>> factorialLogger;

		public FactorialServiceTests()
		{
			factorialLogger = new Mock<ILogger<FactorialService>>();
		}

		[Theory]
		[InlineData(1, 1)]
		[InlineData(2, 2)]
		[InlineData(3, 6)]
		[InlineData(4, 24)]
		[InlineData(5, 120)]
		[InlineData(10, 3628800)]
		public async Task FactorialService_returns_valid_factorial(int input, int output)
		{
			// Arrange
			var factorialService = new FactorialService(factorialLogger.Object);

			// Act
			var result = await factorialService.FindFactorial(input);

			// Assert
			Assert.Equal(result, output);

		}
		
	}
}

