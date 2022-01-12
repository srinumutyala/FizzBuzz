using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzzLibrary
{
	public class FizzBuzzResolver : CategoryResolver
	{

		public override string Resolve(int number)
		{
			if (number.IsFizzBuzz())
				return Constants.FIZZBUZZ;

			return Next.Resolve(number);
		}
	}
}
