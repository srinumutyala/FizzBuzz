using FizzBuzzLibrary;
using System;

namespace FizzBuzzConsole
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Welcome to the FizzBuzz program");
            Console.WriteLine(StaticMethods.PrintHeader());

            try
            {
                var printer = new FizzBuzzPrinter();
                for (int index = 1; index <= 100; index++)
                {
                    Console.WriteLine(printer.PrintFizzBuzz(index));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("There was an issue in the program. Contact administrator!");
                //Console.WriteLine("Message: " + ex.Message);
            }

            Console.WriteLine("Any key to exit>");
            Console.ReadKey();
        }
    }

}
