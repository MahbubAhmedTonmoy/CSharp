using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace CSharp.Extension
{
    class Extension
    {
    }
    public class Calculator
    {
        public int Add(int number1, int number2)
        {
            return number1 + number2;
        }
    }

    public static class CalculatorExtension
    {
        public static int AddList(this Calculator calculator, List<int> numbers)
        {
            int ans = 0;
            foreach(var i in numbers)
            {
                ans += i;
            }
            return ans;
        }
        public static int AddmultipleItems(this Calculator calculator,int number1,[Optional] List<int> numbers)
        {
            int ans = 0;
            if (number1 != null) { ans += number1; }
            if(numbers != null)
            {
                foreach (var i in numbers)
                {
                    ans += i;
                }
            }
            return ans;
        }
    }
}
