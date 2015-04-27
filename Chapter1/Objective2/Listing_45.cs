namespace Chapter1.Objective2
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    [TestClass]
    public class Listing_45
    {
        [TestMethod]
        public void Main() 
        {
            Task longRunning = Task.Run(() => 
            {
                Thread.Sleep(1000);
            });

            int index = Task.WaitAny(new[] { longRunning }, 1000);

            if (index == -1) 
            {
                Console.WriteLine("Task time out");
            }
        }
    }
}
