namespace Chapter1.Objective1
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using System.Collections.Concurrent;
    using System.Threading;
    using System.Threading.Tasks;

    [TestClass]
    public class Listing_34
    {
        [TestMethod]
        public void Main()
        {
            ConcurrentDictionary<string, int> dict = new ConcurrentDictionary<string, int>();

            if (dict.TryAdd("k1", 42)) 
            {
                Console.WriteLine("Added");
            }

            if (dict.TryUpdate("k1", 21, 42))
            {
                Console.WriteLine("42 updated to 21");
            }

            dict["k1"] = 42;

            int r1 = dict.AddOrUpdate("k1", 3, (s, i) => i * 2);
            int r2 = dict.GetOrAdd("k2", 3);

            // Wait until finish
            Console.ReadLine();
        }        
    }
}