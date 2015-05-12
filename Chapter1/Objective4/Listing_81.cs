namespace Chapter1.Objective4
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;

    [TestClass]
    public class Listing_81
    {
        [TestMethod]
        public void Main() 
        {
            Action<int, int> calc = (x, y) => 
            {
                Console.WriteLine(x + y);
            };

            calc(3, 4);
        }
    }
}
