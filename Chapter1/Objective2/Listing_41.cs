namespace Chapter1.Objective2
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    [TestClass]
    public class Listing_41
    {
        static int value = 1;

        [TestMethod]
        public void Main() 
        {
            Task t1 = Task.Run(() => 
            {
                //if (value == 1) 
                //{
                //    Thread.Sleep(1000);
                //    value = 2;
                //}

                Interlocked.CompareExchange(ref value, 2, 1);
            });

            Task t2 = Task.Run(() =>
            {
                value = 3;
            });

            Task.WaitAll(t1, t2);
            Console.WriteLine(value);
        }
    }
}
