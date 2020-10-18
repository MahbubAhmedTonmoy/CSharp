using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CSharp.ExpressionTree
{
    public class ExpressionTreeTest
    {
        private readonly ExpressionTree expressionTree = new ExpressionTree();

        [Fact]
        public void StudentIsTeen()
        {
           var result = expressionTree.GetTeenStudent(new Student { Age = 18 });
            result.Should().Be(true);
        }
        [Fact]
        public void StudentIsTeenV2()
        {
            var result = expressionTree.GetTeenStudentV2(new Student { Age = 18 });
            result.Should().Be(true);
        }
    }
}
