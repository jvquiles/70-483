namespace Chapter1.Objective3
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    
    [TestClass]
    public class Listing_48
    {
        [TestMethod]
        public void Main() 
        {
            bool x = true;
            bool result = x || GetY();
        }

        private bool GetY()
        {
            Console.WriteLine("This method doesn't get called");
            return true;
        }
    }
}
