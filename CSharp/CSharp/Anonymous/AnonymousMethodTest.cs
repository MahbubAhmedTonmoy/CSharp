using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CSharp.Anonymous
{
    public class AnonymousMethodTest
    {
        private readonly AnonymousMethod anonymousMethod = new AnonymousMethod();

        [Fact]
        public void ShouldReturnSumWhenXandYValueProvided()
        {
            int x = 10;
            int y = 20;
            int z = anonymousMethod.Add(x, y);
            z.Equals(30);
        }
    }
}
