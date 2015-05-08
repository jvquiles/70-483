namespace Chapter1.Objective3
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;

    [TestClass]
    public class Listing_70
    {
        [TestMethod]
        public void Main() 
        {
            do
            {
                Console.WriteLine("Executed once!");
            }
            while (false);
        }
    }
}
