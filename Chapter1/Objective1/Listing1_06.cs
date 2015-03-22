namespace Chapter1.Objective1
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using System.Threading;

    [TestClass]
    public class Listing1_06
    {
        public static ThreadLocal<int> _field =
            new ThreadLocal<int>(() =>
            {
                return Thread.CurrentThread.ManagedThreadId;
            });

        [TestMethod]
        public void Main() 
        {
            new Thread(() => 
            {
                for (int x = 0; x < 10; x++)
                {                    
                    Console.WriteLine("Thread A: {0}", x);
                }
            }).Start();

            new Thread(() =>
            {
                for (int x = 0; x < 10; x++)
                {
                    Console.WriteLine("Thread B: {0}", x);
                }
            }).Start();

            Thread.Sleep(10000);
        }
    }
}
