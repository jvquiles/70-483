namespace Chapter1.Objective1
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using System.Threading;

    [TestClass]
    public class Listing1_4
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
            bool stopped = false;

            Thread t = new Thread(new ThreadStart(() => 
            {
                while(!stopped)
                {
                    Console.WriteLine("Running...");
                    Thread.Sleep(1000);
                }
            }));

            t.Start();
            Console.WriteLine("Press any key to exit.");
            //Console.ReadKey();

            Thread.Sleep(10000);

            stopped = true;
            t.Join();
        }
    }
}
