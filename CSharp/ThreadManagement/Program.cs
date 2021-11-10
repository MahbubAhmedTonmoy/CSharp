using System;
using System.Threading;

namespace ThreadManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread[] threads = new Thread[10];
            Department dep = new Department(1000);
            for(int i = 0; i < 10; i++)
            {
                Thread t = new Thread(new ThreadStart(dep.DOTransaction));
                threads[i] = t;
            }
            for(int i = 0; i < 10; i++)
            {
                threads[i].Start();
            }
            Console.ReadLine();
        }
    }
    class Department
    {
        private readonly object lockobject = new object();
        int salary;
        Random r = new Random();
        public Department(int initial)
        {
            salary = initial;
        }
        int Withdraw(int ammount)
        {
            if(salary < 0)
            {
                throw new Exception("o tk");
            }
            lock (lockobject)
            {
                if(salary >= ammount)
                {
                    Console.WriteLine("before" + salary);
                    Console.WriteLine("ammout you withdraw " + ammount);
                    salary = salary - ammount;
                    Console.WriteLine("after" + salary);
                    return ammount;
                }
                else
                {
                    return 0;
                }
            }
        }

        public void DOTransaction()
        {
            for(int i=0;i<10; i++)
            {
                Withdraw(r.Next(1, 100));
            }
        }
    }
}
