using FizzBuzzLibrary;
using FluentAssertions;
using System;
using Xunit;

namespace FizzBuzzUnitTests
{
	public class FizzBuzzResolverTests
	{
		[Theory]
		[InlineData(5, Constants.BUZZ)]
		[InlineData(3, Constants.FIZZ)]
		[InlineData(15, Constants.FIZZBUZZ)]
		[InlineData(7, "7")]
		public void TestFizzBuzzResolver_with_multiple_inputs(int actual, string expected)
		{
			//Arrange
			var sut = new FizzBuzzPrinter();
			//Act
			var result = sut.PrintFizzBuzz(actual);
			//Assert
			result.Should().Be(expected);
		}

		[Fact]
		public void returns_true_when_input_is_divisible_by_3()
		{
			// Arrange
			const int input = 3;
			// Act
			var result = input.IsFizz();
			// Assert
			result.Should().BeTrue();
		}

		[Fact]
		public void returns_true_when_input_is_not_divisible_by_3()
		{
			// Arrange
			const int input = 4;
			// Act
			var result = input.IsFizz();
			// Assert
			result.Should().BeFalse();
		}

		[Fact]
		public void returns_true_when_input_is_divisible_by_5()
		{
			// Arrange
			const int input = 5;
			// Setup
			var result = input.IsBuzz();
			// Assert
			result.Should().BeTrue();
		}

		[Fact]
		public void returns_false_when_6_is_not_divisible_by_5()
		{
			// Arrange
			const int input = 6;
			// Setup
			var result = input.IsBuzz();
			// Assert
			result.Should().BeFalse();
		}

		[Fact]
		public void returns_true_when_15_is_divisible_by_3and5()
		{
			// Arrange
			const int input = 15;
			//Act & Assert
			input.IsFizzBuzz().Should().BeTrue();
		}

		[Fact]
		public void returns_false_when_16_is_not_divisible_by_3and5()
		{
			// Arrange
			const int input = 16;

			//Act & Assert
			input.IsFizzBuzz().Should().BeFalse();
		}

 
    }
}
