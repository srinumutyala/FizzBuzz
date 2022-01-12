using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzzLibrary
{

    /// <summary>
    /// Chain class that sets the resolvers one after the other
    /// </summary>
    public class FizzBuzzCategorizerChain
    {
        private FizzBuzzCategorizerChain()
        {
            Head = new FizzBuzzResolver();
            Head.RegisterNext(new BuzzResolver())
                .RegisterNext(new FizzResolver())
                .RegisterNext(new NumberResolver());
        }
        private FizzBuzzResolver Head { get; set; }

        public static string Resolve(int number)
        {
            return _instance.Head.Resolve(number);
        }

        private static readonly FizzBuzzCategorizerChain _instance = new FizzBuzzCategorizerChain();
    }
}
