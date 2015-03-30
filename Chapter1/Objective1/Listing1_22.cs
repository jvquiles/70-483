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
    public class Listing1_22
    {
        [TestMethod]
        public void Main() 
        {
            var numbers = Enumerable.Range(0, 100000000);
            var paralelelResult = numbers.AsParallel()
                .Where(i => i % 2 == 0)
                .ToArray();
        }
    }
}