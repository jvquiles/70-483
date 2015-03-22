namespace Chapter1.Objective1
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    [TestClass]
    public class Listing1_08
    {
        [TestMethod]
        public void Main() 
        {
            Task t = Task.Run(() => 
            {
                for (int x = 0; x  < 100; x++) 
                {
                    Console.WriteLine("*");
                }
            });

            Thread.Sleep(10000);
        }
    }
}
