namespace Chapter1.Objective3
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;

    [TestClass]
    public class Listing_71
    {
        [TestMethod]
        public void Main() 
        {
            int[] values = { 1, 2, 3, 4, 5, 6 };
            foreach(int i in values)
            {
                Console.Write(i);
            }
        }
    }
}
