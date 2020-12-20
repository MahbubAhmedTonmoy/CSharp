using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CSharp.Extension
{
    public class ExtensionTest
    {
        [Fact]
        public void ShouldSum()
        {
            Calculator c1 = new Calculator();
            int ans = c1.Add(1, 2);
            ans.Should().Be(3);
        }
        [Fact]
        public void ShouldExtensionSumWork()
        {
            Calculator c1 = new Calculator();
            int ans = c1.AddList(new List<int> { 1,2,3});
            ans.Should().Be(6);
        }
        [Fact]
        public void ShouldAddmultipleItemsSumWork()
        {
            Calculator c1 = new Calculator();
            int ans = c1.AddmultipleItems(2,new List<int> { 1, 2, 3 });
            int ans2 = c1.AddmultipleItems(1);
            ans.Should().Be(8);
            ans2.Should().Be(1);
        }
    }
}
