namespace Chapter1.Objective1
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using System.Linq;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using System.Windows;

    [TestClass]
    public class Listing1_24
    {
        [TestMethod]
        public void Main() 
        {
            var numbers = Enumerable.Range(0, 10);
            var paralelelResult = numbers.AsParallel().AsOrdered()
                .Where(i => i % 2 == 0)
                .ToArray();

            foreach(int i in paralelelResult)
            {
                Console.WriteLine(i);
            }
        }
    }
}