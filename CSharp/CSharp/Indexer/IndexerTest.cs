using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CSharp.Indexer
{
    public class IndexerTest
    {
        private readonly Indexer indexer = new Indexer();

        [Fact]
        public void ShouldGetItemFromObjectWhenValidIndexProvided()
        {
            string id = indexer["Id"];
            string name = indexer["Name"];
            id.Should().Be("100");
            name.Should().Be("student");
        }

        [Fact]
        public void ShouldGetObjectStudentSet()
        {
            Student student = indexer[0];
            student.Id.Should().Be(101);
        }
        [Fact]
        public void ShouldAddObjectStudentSet()
        {

            Student student = new Student { Id = 105, Name = "student5" };
            indexer[4] = student;
            Student student5 = indexer[4];
            student5.Id.Should().Be(105);
        }
    }
}
