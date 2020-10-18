using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CSharp.Partial
{
    public class PartialClassTest
    {
        private readonly PurchaseService purchaseService = new PurchaseService();
        private readonly UserService userService = new UserService();

        [Fact]
        public void ShouldReturnTodaysPurchaseAmount()
        {
            int result = purchaseService.GetTodayPurchase();
            result.Should().Be(100);
        }
        [Fact]
        public void ShouldReturnYesterdayPurchaseAmount()
        {
            int result = purchaseService.GetYesterdayPurchase();
            result.Should().Be(200);
        }
        [Fact]
        public void shouldUserIdValid()
        {
            var  result = userService.IsValidUser("34114393-176d-18ef-3fcf-203de94146f0");
            result.Should().BeTrue();
        }
    }
}
