using System;
using System.Collections.Generic;
using System.Text;


namespace FizzBuzzLibrary
{
    /// <summary>
    /// Extension methods to evaluate the FizzBuzz
    /// </summary>
    public static class FizzBuzzEvaluator
    {

        public static bool IsFizz(this int NumberToEvaluate) => (NumberToEvaluate % Constants.FIZZ_NUMBER) == 0;
  
        public static bool IsBuzz(this int NumberToEvaluate) => (NumberToEvaluate % Constants.BUZZ_NUMBER) == 0;

        public static bool IsFizzBuzz(this int NumberToEvaluate) => (IsFizz(NumberToEvaluate) && IsBuzz(NumberToEvaluate));

        
    }
}