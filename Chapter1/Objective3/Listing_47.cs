namespace Chapter1.Objective3
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;

    [TestClass]
    public class Listing_47
    {
        [TestMethod]
        public void Main() 
        {
            bool x = true;
            bool y = false;

            bool result = x || y;
            Console.WriteLine(result);
        }
    }
}
