using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Parallel1
{
    public class Data
    {
        public int Id { get; set; }
        public int Value { get; set; }
    }
    public class ParallelClass
    {
        /// Process data list using parallel programming -> using foreach loop
        public void ProcessData(IEnumerable<Data> datas)
        {
            var options = new ParallelOptions { MaxDegreeOfParallelism = 2 };

            Parallel.ForEach(datas, options, item =>
            {
                Debug.WriteLine($"{item.Id}- {item.Value}");
            });
        }

        /// Process data list using parallel programming -> using for loop
        public void ProcessData(Data[] datas)
        {
            var options = new ParallelOptions { MaxDegreeOfParallelism = 2 };

            Parallel.For(0, datas.Length - 1, options, i =>
             {
                 Debug.WriteLine($"{datas[i].Id}- {datas[i].Value}");
             });
        }

        /// Process data list using parallel programming -> using ParallelQuery
        public void ProcessDataUsingParallelQuery(IEnumerable<Data> datas)
        {
            var options = new ParallelOptions { MaxDegreeOfParallelism = 2 };
            datas.AsParallel().ForAll(item =>
            {
                Debug.WriteLine($"{item.Id}- {item.Value}");
            }); 
        }

        /// Execute list of methods parallelly - using Invoke()
        public void Process(Action method1, Action method2)
        {
            var options = new ParallelOptions { MaxDegreeOfParallelism = 3 };
            Parallel.Invoke(options, method1, method2);
        }
    }
}
