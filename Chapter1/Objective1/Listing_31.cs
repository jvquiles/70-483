namespace Chapter1.Objective1
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using System.Collections.Concurrent;
    using System.Threading;
    using System.Threading.Tasks;

    [TestClass]
    public class Listing_31
    {
        [TestMethod]
        public void Main()
        {
            ConcurrentBag<int> bag = new ConcurrentBag<int>();
            
            Task.Run(() => 
            {
                bag.Add(42);
                Thread.Sleep(1000);
                bag.Add(21);
            });

            Task.Run(() => 
            {
                Thread.Sleep(100);
                foreach(int i in bag)
                {
                    Console.WriteLine(i);
                }
            }).Wait();

            // Wait until finish
            Console.ReadLine();
        }        
    }
}