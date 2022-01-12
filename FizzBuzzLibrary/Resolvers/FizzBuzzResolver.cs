using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzzLibrary
{
	/// <summary>
	/// Class that is responsible for checking the number is divisible by both 3 & 5
	/// </summary>
	public class FizzBuzzResolver : CategoryResolver
	{
		/// <summary>
		/// Method that returns "FizzBuzz" if the input is divisible by 3 & 5. Calls the next resolver otherwise
		/// </summary>
		/// <param name="number"></param>
		/// <returns></returns>
		public override string Resolve(int number)
		{
			if (number.IsFizzBuzz())
				return Constants.FIZZBUZZ;

			return Next.Resolve(number);
		}
	}
}
