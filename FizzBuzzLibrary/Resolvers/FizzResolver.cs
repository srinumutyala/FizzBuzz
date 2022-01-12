using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzzLibrary
{

    public class FizzResolver : CategoryResolver
    {
        private const int FIZZ_NUMBER = 3;

        /// <summary>
        /// Method that returns "Fizz" if the input is divisible by 3. Calls the next resolver otherwise
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public override string Resolve(int number)
        {
            if (IsFizz(number))
                return Constants.FIZZ;

            return Next.Resolve(number);
        }

        private bool IsFizz(int NumberToEvaluate) => (NumberToEvaluate % FIZZ_NUMBER) == 0;
    }
}
