using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzzLibrary
{
	public class FizzBuzzPrinter
	{
		public string PrintFizzBuzz(int number)
		{
			return FizzBuzzCategorizerChain.Resolve(number);
		}
	}
}
