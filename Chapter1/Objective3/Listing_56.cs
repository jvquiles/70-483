namespace Chapter1.Objective3
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;

    [TestClass]
    public class Listing_56
    {
        [TestMethod]
        public void Main() 
        {
            bool b = false;
            bool c = true;

            if (b)
            {
                Console.WriteLine("b is true");
            }
            else if (c)
            {
                Console.WriteLine("c is true");
            }
            else
            {
                Console.WriteLine("b and c are false");
            }
        }
    }
}
