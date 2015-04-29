namespace Chapter1.Objective3
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    
    [TestClass]
    public class Listing_53
    {
        [TestMethod]
        public void Main() 
        {
            bool b = true;
            if (b)
            {
                Console.WriteLine("Both these lines");
                Console.WriteLine("Will be executed");
            }
        }
    }
}
