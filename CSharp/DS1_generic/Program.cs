using System;

namespace DS1_generic
{
    /// <summary>
    /// create a generic class thak takes one generic parameter. this parameter should thake only class.
    /// anything other then class can not be set in generic parapeter. this class has a method name 
    /// object CallPrivate(string methodName, object[] parameters). when this method is called, it will execute
    /// the private method of the generic parameter class
    /// </summary>

    //public delegate void Notify();  // delegate

    public class ProcessBusinessLogic
    {
        //public event Notify ProcessCompleted; // event
        public event EventHandler ProcessCompleted; // event
        public void StartProcess()
        {
            Console.WriteLine("Process Started!");
            // some code here..
            OnProcessCompleted(EventArgs.Empty);
        }

        protected virtual void OnProcessCompleted(EventArgs e) //protected virtual method
        {
            //if ProcessCompleted is not null then call delegate
            ProcessCompleted?.Invoke(this, e);
        }
    }
    class Program
    {
        public static void Main()
        {
            ProcessBusinessLogic bl = new ProcessBusinessLogic();
            bl.ProcessCompleted += bl_ProcessCompleted; // register with an event
            bl.StartProcess();
        }

        // event handler
        public static void bl_ProcessCompleted(object sender, EventArgs e)
        {
            Console.WriteLine("Process Completed!");
        }
    }

    public class GenericClass<T> where T: class
    {
        public T data { get; set; }
        public GenericClass(T inputclass)
        {
            this.data = inputclass;
        }
    }
}
