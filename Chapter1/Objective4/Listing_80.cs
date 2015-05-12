namespace Chapter1.Objective4
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;

    [TestClass]
    public class Listing_80
    {
        public delegate int Calculate(int x, int y);

        [TestMethod]
        public void Main() 
        {
            Calculate calc =
                (x, y) =>
                {
                    Console.WriteLine("Adding numbers");
                    return x + y;
                };

            int result = calc(3, 4);
        }
    }
}
