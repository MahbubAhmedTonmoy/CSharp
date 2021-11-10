using System;
using System.Linq;
using System.Linq.Expressions;

namespace LinQ
{
    class Program
    {
        public delegate T mathDelegate<T>(T a, T b);
        static void Main(string[] args)
        {
            //LinqTest();
            // PatternMatching();
            DelegateTest();
        }

        private static void DelegateTest()
        {
            //mathDelegate<int> math = Add;
            //int result = math(1, 2);
            //Console.WriteLine(result);

            

            mathDelegate<int> mathDelegate = delegate (int a, int b)
            {
                return a + b;
            };
            Console.WriteLine(mathDelegate(1, 2));

            Func<int, int, int> abc = (int x, int y) => x + y;
            Console.WriteLine(abc(1, 2));
        }

        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static void PatternMatching()
        {
            var dataset = new DataSet();
            var data = dataset.dataset();

            var check =  data[0] is Student;
            var a = data[0].GetType() == typeof(Student) ? true : false;
            if(data[0].GetType() == typeof(Fruit))
            {
                Console.WriteLine(data[0].Id);
            }
        }
        private static void LinqTest()
        {
            var dataset = new DataSet();
            var data = dataset.dataset();

            //where
            var whereResult = data.Where(x => x.Age >= 20 && x.Age <= 25);
            Console.WriteLine(whereResult.Count());
            //where 2nd method
            var r = data.Where((s, i) =>
            {
                if (s.Age % 2 == 0)
                {
                    return true;
                }
                return false;
            });

            foreach (var i in r)
            {
                Console.WriteLine($"{i.Id}  {i.Name}");
            }

            //--------
            //=========ofType
            var oftypeResult = data.Select(x => x.Remarks.OfType<string>());
            Console.WriteLine("ofType result {0}", oftypeResult.Count());

            //order by theb by
            Console.WriteLine("order by then by");
            var orderByresult = data.OrderBy(x => x.Age).ThenBy(x => x.Name);
            foreach (var i in orderByresult)
            {
                Console.WriteLine($"{i.Id}  {i.Name} {i.Age}");
            }

            // GroupBy ToLookup
            Console.WriteLine("==========group by==============");
            var groupbyresult = data.GroupBy(x => x.Age).OrderBy(x => x.Key);
            foreach (var i in groupbyresult)
            {
                Console.WriteLine("group key {0}", i.Key);
                foreach (var j in i)
                {
                    Console.WriteLine($"id: {j.Id} Name: {j.Name} Age: {j.Age}");
                }
            }

            //***************select many : list -> list ?? selectmany get only 1 list
            var selectmany = data.Select(student => student.PhoneNumber);
        }
    }
}
