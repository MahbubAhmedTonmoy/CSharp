using CSharp.Parallel1;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CSharp.Parallel1
{
    public class ParallelClassTest
    {
        private readonly ParallelClass parallelObject = new ParallelClass();

        [Fact]
        public void ShouldProcessWhenDataProvided()
        {
            var dataList = new List<Data> { new Data { Id = 1, Value = 100 }, new Data { Id = 2, Value = 200 }, new Data { Id = 3, Value = 300 }, };
            Data[] dataArray = dataList.ToArray();

            parallelObject.ProcessData(dataList);
            parallelObject.ProcessData(dataArray);
        }
        [Fact]
        public void ShouldProcessWhenDataProvidedUsingParallelQuery()
        {
            var dataList = new List<Data> { new Data { Id = 1, Value = 100 }, new Data { Id = 2, Value = 200 }, new Data { Id = 3, Value = 300 }, };

            parallelObject.ProcessDataUsingParallelQuery(dataList);
        }

        [Fact]
        public void SholdProcesWhenMethodListProvided()
        {
            var method1 = new Action(() => { Console.WriteLine("Hello"); });

            var method2 = new Action(() =>
            {
                for (var i = 0; i < 10; i++)
                {
                    Console.WriteLine("Hello");
                }
            });
            parallelObject.Process(method1, method2);
        }
    }
}
