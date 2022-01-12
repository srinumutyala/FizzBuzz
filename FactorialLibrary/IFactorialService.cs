using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FactorialLibrary
{
	public interface IFactorialService
	{
		Task<int> FindFactorial(int number);
	}
}
