namespace Chapter2.Objective5
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Diagnostics;

    [TestClass]
    public class Listing_59
    {
        [Conditional("CONDITION1"), Conditional("CONDITION2")]
        static void MyMethod() { }

        [TestMethod]
        public void Main() 
        {

        }
    }
}
