namespace Chapter1.Objective2
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    [TestClass]
    public class Listing_37
    {
        [TestMethod]
        public void Main() 
        {
            object lockA = new object();
            object lockB = new object();

            var up = Task.Run(() =>
            {
                lock (lockA) 
                {
                    Thread.Sleep(10000);
                    lock (lockB) 
                    {
                        Console.WriteLine("Locked A and B");
                    }
                }
            });

            lock (lockB) 
            {
                lock (lockA) 
                {
                    Console.WriteLine("Locked A and B");
                }
            }

            up.Wait();
        }
    }
}
