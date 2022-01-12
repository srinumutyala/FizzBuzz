using FizzBuzzLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzzConsole
{
    public static class StaticMethods
    {
        public static string PrintHeader()
        {
            var header = new StringBuilder();
            header.AppendLine("Fizz: if the number is multiple of 3.");
            header.AppendLine("Buzz:  if the number is multiple of 5.");
            header.AppendLine("FizzBuzz:  if the number is multiple of both 3 and 5.");
            header.AppendLine();
            return header.ToString();
        }
    }
}
