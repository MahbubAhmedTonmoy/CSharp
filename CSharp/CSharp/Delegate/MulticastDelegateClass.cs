using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Delegate
{
    public class MulticastDelegateClass
    {
        private delegate int TotalEmployee();

        private List<TotalEmployee> totalEmployeeDelegates = new List<TotalEmployee>();

        private readonly System.Delegate allDelegates;
        public MulticastDelegateClass()
        {
            totalEmployeeDelegates.Add(FullTimeEmployee);
            totalEmployeeDelegates.Add(PartTimeEmployee);
            allDelegates = MulticastDelegate.Combine(totalEmployeeDelegates.ToArray());
        }

        public int CountTotalEmployee()
        {
            int total = 0;
            foreach(System.Delegate i in allDelegates.GetInvocationList())
            {
                total += (int)i.DynamicInvoke();
            }
            return total;
        }

        private int PartTimeEmployee()
        {
            return 100;
        }

        private int FullTimeEmployee()
        {
            return 200;
        }
    }
}
