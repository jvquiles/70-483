namespace Chapter1.Objective1
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using System.Collections.Concurrent;
    using System.Threading;
    using System.Threading.Tasks;

    [TestClass]
    public class Listing_33
    {
        [TestMethod]
        public void Main()
        {
            ConcurrentQueue<int> queue = new ConcurrentQueue<int>();
            queue.Enqueue(42);

            int result;
            if (queue.TryDequeue(out result)) 
            {
                Console.WriteLine("Dequeued: {0}", result);
            }

            // Wait until finish
            Console.ReadLine();
        }        
    }
}