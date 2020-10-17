using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Anonymous
{
    public class AnonymousMethod
    {
        private delegate int AddDelegate(int x, int y);

        public int Add(int x, int y)
        {
            AddDelegate add = delegate (int x, int y)
            {
                return x + y;
            };

            return add(x, y);
        }
    }
}
