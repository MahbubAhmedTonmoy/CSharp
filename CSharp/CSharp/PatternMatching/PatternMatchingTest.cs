using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CSharp.PatternMatching
{
    public class PatternMatchingTest
    {
        private readonly PatternMatching patternMatching = new PatternMatching();

        [Fact]
        public void ShouldIsFullTimeStudent()
        {
            var StudentBase = new FullTimeStudent { Id = 101, Name = "student" };
            var result = patternMatching.IsFullTimeStudent(StudentBase);
            result.Should().BeTrue();
        }

        [Fact]
        public void ShouldFindCountryNameValid()
        {
            var result = patternMatching.FindCountryName("bd");
            result.Should().Be("Bangladesh");
        }

        [Fact]
        public void ShouldValidCalculatePoint()
        {
            var fullTimeStudent = new FullTimeStudent { Id = 101, Name = "student1" };
            var partTimeStudent = new PartTimeStudent { Id = 102, Name = "student2", Age = 11 };
            var otherStudent = new StudentBase { Id = 103, Name = "student2" };
            int bonusPointForFullTimeStudent = patternMatching.CalculatePoint(fullTimeStudent);
            int bonusPointForPartTimeStudent = patternMatching.CalculatePoint(partTimeStudent);
            int fordefault = patternMatching.CalculatePoint(otherStudent);

            bonusPointForFullTimeStudent.Should().Be(200);
            bonusPointForPartTimeStudent.Should().Be(100);
            fordefault.Should().Be(0);
        }
    }
}
