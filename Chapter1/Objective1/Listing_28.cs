namespace Chapter1.Objective1
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using System.Collections.Concurrent;
    using System.Threading.Tasks;

    [TestClass]
    public class Listing_28
    {
        [TestMethod]
        public void Main() 
        {
            BlockingCollection<string> col = new BlockingCollection<string>();
            Task read = Task.Run(() => 
            {
                while (true) 
                {
                    Console.WriteLine(col.Take());
                }
            });

            Task write = Task.Run(() => 
            {
                while (true) 
                {
                    string s = Console.ReadLine();
                    if (string.IsNullOrEmpty(s)) 
                    {
                        break;
                    }

                    col.Add(s);
                }
            });

            write.Wait();

            // Wait until finish
            Console.ReadLine();
        }
    }
}