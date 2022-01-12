using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzzLibrary
{
	/// <summary>
	/// Class that invokes the FizzBuzzResolverChain
	/// </summary>
	public class FizzBuzzPrinter
	{
		public string PrintFizzBuzz(int number)
		{
			return FizzBuzzCategorizerChain.Resolve(number);
		}
	}
}
