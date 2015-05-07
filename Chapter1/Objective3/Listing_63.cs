namespace Chapter1.Objective3
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;

    [TestClass]
    public class Listing_63
    {
        [TestMethod]
        public void Main() 
        {
            int i = 1;
            switch (i)
            {
                case 1:                    
                    {
                        Console.WriteLine("Case 1");
                        goto case 2;
                    }
                case 2:
                    {
                        Console.WriteLine("Case 2");
                        break;
                    }
            }
        }
    }
}
