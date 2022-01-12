using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzzLibrary
{
	public abstract class CategoryResolver
    {
        public CategoryResolver RegisterNext(CategoryResolver next)
        {
            Next = next;
            return Next;
        }

        protected CategoryResolver Next { get; private set; }

        public abstract string Resolve(int number);

    }
}
