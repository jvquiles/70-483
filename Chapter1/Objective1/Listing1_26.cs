namespace Chapter1.Objective1
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using System.Linq;

    [TestClass]
    public class Listing1_26
    {
        [TestMethod]
        public void Main() 
        {
            var numbers = Enumerable.Range(0, 20);
            var paralelelResult = numbers.AsParallel()
                .Where(i => i % 2 == 0);

            paralelelResult.ForAll(e => Console.WriteLine(e));
        }
    }
}