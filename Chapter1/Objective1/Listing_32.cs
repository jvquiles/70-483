namespace Chapter1.Objective1
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using System.Collections.Concurrent;
    using System.Threading;
    using System.Threading.Tasks;

    [TestClass]
    public class Listing_32
    {
        [TestMethod]
        public void Main()
        {
            ConcurrentStack<int> stack = new ConcurrentStack<int>();

            stack.Push(42);

            int result;
            if (stack.TryPop(out result))
            {
                Console.WriteLine("Poped: {0}", result);
            }

            stack.PushRange(new int[] { 1, 2, 3 });

            int[] values = new int[2];
            stack.TryPopRange(values);

            foreach (int i in values) 
            {
                Console.WriteLine(i);
            }

            // Wait until finish
            Console.ReadLine();
        }        
    }
}