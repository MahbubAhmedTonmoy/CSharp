using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Delegate
{
    public class DelegateClass
    {
        public delegate int GetTotalSalary();

        public int GetTotalSalaryAmount(int employeeType)
        {
            GetTotalSalary getTotalSalary = null;

            if(employeeType == 0)
            {
                getTotalSalary = GetConsultantsTotalSalary;
            }
            else if (employeeType == 1) //director
            {
                getTotalSalary = GetDirectorsTotalSalary;
            }
            else if (employeeType == 20) //general employee
            {
                getTotalSalary = GetEmployeesTotalSalary;
            }
            else
            {
                throw new ApplicationException("Sorry! Not a valid employee type.");
            }

            int totalSalaryAmount = getTotalSalary();
            return totalSalaryAmount;
        }
        public int GetTotalSalaryAmountUsingFuncBuitinDelegate(int employeeType)
        {
            Func<decimal, int> getTotalSalaryIncludingTax = null;

            if (employeeType == 1) //consultant
            {
                getTotalSalaryIncludingTax = GetConsultantsTotalSalaryWithTax;
            }
            else if (employeeType == 2) //general employee
            {
                getTotalSalaryIncludingTax = GetDirectorsTotalSalaryWithTax;
            }
            else
            {
                throw new ApplicationException("Sorry! Not a valid employee type.");
            }
            var taxPercentage = (decimal).10;
            int totalSalaryAmount = getTotalSalaryIncludingTax(taxPercentage);
            return totalSalaryAmount;
        }

        private int GetConsultantsTotalSalary()
        {
            return 200;
        }

        private int GetEmployeesTotalSalary()
        {
            return 100;
        }

        private int GetDirectorsTotalSalary()
        {
            return 300;
        }

        private int GetConsultantsTotalSalaryWithTax(decimal taxPercentAmount)
        {
            return 100 + (int)(100 * taxPercentAmount);
        }

        private int GetDirectorsTotalSalaryWithTax(decimal taxPercentAmount)
        {
            return 200 + (int)(200 * taxPercentAmount);
        }
    }


}
