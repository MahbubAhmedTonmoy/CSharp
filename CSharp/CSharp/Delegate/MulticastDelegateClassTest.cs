using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CSharp.Delegate
{
    public class MulticastDelegateClassTest
    {
        private readonly MulticastDelegateClass multicastDelegateObject = new MulticastDelegateClass();

        [Fact]
        public void ShouldReturnAllEmployeesCount()
        {
            int total = multicastDelegateObject.CountTotalEmployee();
            total.Should().Be(300);
        }
    }
}
