using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzzLibrary
{
	public class BuzzResolver : CategoryResolver
    {
        private const int BUZZ_NUMBER = 5;
        public override string Resolve(int number)
        {
            if (IsBuzz(number))
                return Constants.BUZZ;

            return Next.Resolve(number);
        }

        private bool IsBuzz(int NumberToEvaluate) => (NumberToEvaluate % BUZZ_NUMBER) == 0;
    }
}
