using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Anonymous
{
    public class AnonymousMethod
    {
        private delegate int AddDelegate(int x, int y);

        private delegate int CalculatorDelegate<T>(T x, T y);

        public int Add(int x, int y)
        {
            AddDelegate add = delegate (int x, int y)
            {
                return x + y;
            };

            return add(x, y);
        }

        public int multiply(int x , int y)
        {
            CalculatorDelegate<int> multi = delegate (int x, int y)
            {
                return x * y;
            };
            return multi(x, y);
        }
    }
}
