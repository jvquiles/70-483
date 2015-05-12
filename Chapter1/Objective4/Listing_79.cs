namespace Chapter1.Objective4
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;

    [TestClass]
    public class Listing_79
    {
        public delegate int Calculate(int x, int y);

        [TestMethod]
        public void Main()
        {
            Calculate calc = (x, y) => x + y;
            Console.WriteLine(calc(3, 4));
            calc = (x, y) => x * y;
            Console.WriteLine(calc(3, 4));
        }
    }
}
