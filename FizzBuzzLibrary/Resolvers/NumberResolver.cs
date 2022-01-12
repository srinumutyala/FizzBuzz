using System.Globalization;

namespace FizzBuzzLibrary
{
    /// <summary>
    /// NumberResolver class that just returns the same number
    /// </summary>
	public class NumberResolver : CategoryResolver
    {
        /// <summary>
        /// Method that returns the same number in string format
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public override string Resolve(int number)
        {
            return number.ToString(CultureInfo.InvariantCulture);
        }
    }
}
