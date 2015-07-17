namespace Chapter2.Objective5
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    
    [TestClass]
    public class Listing_66
    {
        [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class)]
        private class MyMultipleUsageAttribute : Attribute 
        {

        }

        [TestMethod]
        public void Main() 
        {

        }
    }
}
