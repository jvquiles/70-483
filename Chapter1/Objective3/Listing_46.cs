namespace Chapter1.Objective3
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;

    [TestClass]
    public class Listing_46
    {
        [TestMethod]
        public void Main() 
        {
            int x = 42;
            int y = 1;
            int z = 42;

            Console.WriteLine(x == y);
            Console.WriteLine(x == z);
        }
    }
}
