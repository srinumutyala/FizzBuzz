using System.Globalization;

namespace FizzBuzzLibrary
{

	public class NumberResolver : CategoryResolver
    {
        public override string Resolve(int number)
        {
            return number.ToString(CultureInfo.InvariantCulture);
        }
    }
}
