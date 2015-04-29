namespace Chapter1.Objective3
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;

    [TestClass]
    public class Listing_51
    {
        [TestMethod]
        public void Main() 
        {
            bool a = true;
            bool b = false;

            Console.WriteLine(a ^ a);
            Console.WriteLine(a ^ b);
            Console.WriteLine(b ^ b);
        }
    }
}
