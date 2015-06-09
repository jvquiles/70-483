namespace Chapter2.Objective2
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;

    [TestClass]
    public class Listing_22
    {
        [TestMethod]
        public void Main() 
        {
            double x = 1234.7;
            int a;
            // Cast double to int
            a = (int)x;
            Console.WriteLine(a);
        }
    }
}
