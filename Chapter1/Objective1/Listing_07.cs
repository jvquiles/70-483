namespace Chapter1.Objective1
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using System.Threading;

    [TestClass]
    public class Listing_07
    {
        [TestMethod]
        public void Main() 
        {
            ThreadPool.QueueUserWorkItem((s) => 
            {
                Console.WriteLine("Working on a thread from threadpool.");
            });

            // Wait until finish
            Console.ReadLine();
        }
    }
}
