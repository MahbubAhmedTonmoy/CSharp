using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CSharp.Nullable
{
    public class NullableClassTest
    {
        private readonly NullableClass nullableClass = new NullableClass();

        [Fact]
        public void ShouldGetAge()
        {
            var result = nullableClass.GetAge();
            result.Should().Be(-1);
        }
        [Fact]
        public void ShouldSetAge()
        {
            var result = nullableClass.SetAge(50);
            result.Should().Be(50);
        }
        [Fact]
        public void SholdReturnTrueWhenGraterThan50AgeProvided()
        {
            var result = nullableClass.IsAgeGreaterThen50(51);
            result.Should().BeTrue();
        }
    }
}
