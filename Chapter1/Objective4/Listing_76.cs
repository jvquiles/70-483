namespace Chapter1.Objective4
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;

    [TestClass]
    public class Listing_76
    {
        [TestMethod]
        public void Main() 
        {
            this.Multicast();
        }

        delegate void del();

        public void MethodOne()
        {
            Console.WriteLine("MethodOne");
        }

        public void MethodTwo() 
        {
            Console.WriteLine("MethodTwo");
        }

        public void Multicast()
        {            
            del d = this.MethodOne;
            d += this.MethodTwo;

            d();
        }
    }
}
