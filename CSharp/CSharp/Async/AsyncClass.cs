using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharp.Async
{
    public class AsyncClass
    {
        public Task Process1Async()
        {
            Task task = Task.Delay(3000);
            return task;
        }
        public Task Process2Async()
        {
            Task task = Task.Delay(4000);
            return task;
        }

        public Task ExecuteAsync()
        {
            var action = new Action(VisitIntegerNumber);
            var task = new Task(action);
            task.Start();
            return task;
        }
        public Task ExecutewithCancelSupportAsync()
        {
            var cancelSource = new CancellationTokenSource();
            var token = cancelSource.Token;

            Task task = Task.Run(() =>
            {
                LongRunningOperation(token);
            });

            // send signal to cancel execution
            cancelSource.Cancel();
            return task;
        }

        private void VisitIntegerNumber()
        {
            for(int i =0;i<int.MaxValue; i++)
            {

            }
            Debug.Write($"Completed visited upto {int.MaxValue - 1}");
        }

        private void LongRunningOperation(CancellationToken token)
        {
            for (int i = 0; i < int.MaxValue; i++)
            {
                if (token.IsCancellationRequested)
                {
                    token.ThrowIfCancellationRequested();
                }
            }
            Debug.Write($"Completed counting {int.MaxValue} sequentially!");
        }
    }
}
