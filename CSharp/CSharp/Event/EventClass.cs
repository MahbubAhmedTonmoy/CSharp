using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace CSharp.Event
{
    public class EmployeeService
    {
        public delegate void AccountLockedDelegate(string employeeId, string employeeName);
        public event AccountLockedDelegate AccountLockedEvent;
        private readonly AccountService accountService;

        public EmployeeService(AccountService accountService)
        {
            this.accountService = accountService;
        }

        public bool ResignEmployee(string employeeId)
        {
            Debug.WriteLine($"Resign Employee={employeeId}");
            bool accountLocked = accountService.LockEmployeeAccount(employeeId);
            if (accountLocked && AccountLockedEvent != null)
            {
                AccountLockedEvent(employeeId, $"Mr.{employeeId}");
            }
            return true;
        }
    }

    public class AccountService
    {
        public bool LockEmployeeAccount(string employeeId)
        {
            Debug.WriteLine($"Locked Employee = {employeeId}");
            return true;
        }
    }
}
