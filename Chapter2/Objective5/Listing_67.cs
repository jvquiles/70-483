namespace Chapter2.Objective5
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class Listing_67
    {
        [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
        private class MyMultipleUsageAttribute : Attribute { }

        [TestMethod]
        public void Main() 
        {

        }
    }
}
