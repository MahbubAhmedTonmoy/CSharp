using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CSharp.DynamicType
{
    public class DynamicTypeTest
    {
        private readonly DynamicType dynamicType = new DynamicType();

        [Fact]
        public void ShouldCreateDynamicEmployeeWhenEmployeePropertiesProvided()
        {
            var dateOfBirth = new DateTime(1998, 08, 15);
            dynamic employee = dynamicType.CreateDynamicEmployee(1000, "employee", dateOfBirth);
            int employeeId = employee.Id;
            DateTime employeeDateOfBirth = employee.DateOfBirth;

            employeeId.Should().Be(1000);
            employeeDateOfBirth.Should().Be(dateOfBirth);
        }
    }
}
