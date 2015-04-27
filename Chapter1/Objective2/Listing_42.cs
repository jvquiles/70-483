namespace Chapter1.Objective2
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    [TestClass]
    public class Listing_42
    {
        [TestMethod]
        public void Main() 
        {
            CancellationTokenSource cancellationTokenSource =
                new CancellationTokenSource();

            Task task = Task.Run(() => 
            {
                while (!cancellationTokenSource.IsCancellationRequested)
                {
                    Console.Write("*");
                    Thread.Sleep(1000);
                }
            });

            Console.WriteLine("Press enter to stop the task");
            Console.ReadLine();
            cancellationTokenSource.Cancel();

            Console.WriteLine("Press enter to end the aplication");
            Console.ReadLine();
        }
    }
}
