using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FactorialLibrary
{
	/// <summary>
	/// Interfact for declaring the factorial method
	/// </summary>
	public interface IFactorialService
	{
		/// <summary>
		/// Method declaration for find factorial for given number
		/// </summary>
		/// <param name="number"></param>
		/// <returns></returns>
		Task<int> FindFactorial(int number);
	}
}
