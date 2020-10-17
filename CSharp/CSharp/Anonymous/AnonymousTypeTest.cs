using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CSharp.Anonymous
{
    public class AnonymousTypeTest
    {
        private readonly AnonymousType anonymousType = new AnonymousType();

        [Fact]
        public void ShouldReturnStudentAnonymousType()
        {
            var student = anonymousType.CreateAnonymousStudent("101", "student");
            student.Should().NotBeNull();
        }
        [Fact]
        public void ShuoldReturnStudentAnonymousTypeId()
        {
            var student = new { Id = 100, Name = "student" };
            int id = anonymousType.ExtractAnonymousStudentId(student);
            id.Should().Be(100);
        }

        [Fact]
        public void ShuoldReturnStudentAnonymousTypeIdV2()
        {
            var student = new { Id = 100, Name = "student" };
            int id = anonymousType.ExtractAnonymousStudentIdV2(student);
            id.Should().Be(100);
        }
    }
}
