namespace Chapter1.Objective1
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using System.Threading;

    [TestClass]
    public class Listing_03
    {
        static void ThreadMethod(object o)
        {
            for (int i = 0; i < (int)o; i++) 
            {
                Console.WriteLine("ThreadProc: {0}", i);
                Thread.Sleep(0);
            }
        }

        [TestMethod]
        public void Main() 
        {
            Thread t = new Thread(new ParameterizedThreadStart(ThreadMethod));
            t.Start(5);
            t.Join();

            // Wait until finish
            Console.ReadLine();
        }
    }
}
