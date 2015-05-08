namespace Chapter1.Objective3
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;

    [TestClass]
    public class Listing_74
    {
        [TestMethod]
        public void Main() 
        {
            int x = 3;
            if (x == 3)
            {
                goto customLabel;
            }

            x++;

            customLabel:
                Console.WriteLine(x);
        }
    }
}
