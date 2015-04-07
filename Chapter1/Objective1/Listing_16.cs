namespace Chapter1.Objective1
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;

    [TestClass]
    public class Listing_16
    {
        [TestMethod]
        public void Main() 
        {
            Parallel.For(0, 10, i => 
            {
                Thread.Sleep(1000);
            });

            var numbers = Enumerable.Range(0, 10);
            Parallel.ForEach(numbers, i => 
            {
                Thread.Sleep(1000);
            });

            // Wait until finish
            Console.ReadLine();
        }
    }
}