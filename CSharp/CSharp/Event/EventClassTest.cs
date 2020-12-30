using CSharp.Event2;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;
using Xunit;

namespace CSharp.Event
{
    public class EventClassTest
    {
        private readonly EmployeeService employeeService;
        private readonly AccountService accountService;

        public EventClassTest()
        {
            accountService = new AccountService();
            employeeService = new EmployeeService(accountService);

            employeeService.AccountLockedEvent += delegate (string employeeId, string employeeName)
            {
                Debug.WriteLine($"Locked Employee Name={employeeName}");
            };
        }

        public object succeed { get; private set; }

        [Fact]
        public void LockEmployeeAccountWhenEmployeeResigned()
        {
            string id = "10001";
            bool result = employeeService.ResignEmployee(id);

            result.Should().Be(true);
        }
        [Fact]
        public void ShouldWorkEvent2()
        {
            var c = new Counter();
            c.ThresholdReached += c_ThresholdReached;
            static void c_ThresholdReached(object sender, EventArgs e)
            {
                Debug.WriteLine("The threshold was reached.");
            }
        }

    }
       
}
