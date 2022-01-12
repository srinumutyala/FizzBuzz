using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzzLibrary
{
    /// <summary>
    /// Implementation of the BuzzResolver
    /// </summary>
	public class BuzzResolver : CategoryResolver
    {
        private const int BUZZ_NUMBER = 5;

        /// <summary>
        /// Method that returns "Buzz" if the input is divisible by 5. Calls the next resolver otherwise
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public override string Resolve(int number)
        {
            if (IsBuzz(number))
                return Constants.BUZZ;

            return Next.Resolve(number);
        }

        private bool IsBuzz(int NumberToEvaluate) => (NumberToEvaluate % BUZZ_NUMBER) == 0;
    }
}
