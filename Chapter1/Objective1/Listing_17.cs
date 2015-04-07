namespace Chapter1.Objective1
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;

    [TestClass]
    public class Listing_17
    {
        [TestMethod]
        public void Main() 
        {
            ParallelLoopResult result = Parallel.For(0, 1000, (int i, ParallelLoopState loopState) => 
            {
                if (i == 500) 
                {
                    Console.WriteLine("Breaking loop");
                    loopState.Break();
                }

                return;
            });

            // Wait until finish
            Console.ReadLine();
        }
    }
}