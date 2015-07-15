namespace Chapter2.Objective5
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using Xunit;

    [TestClass]
    public class Listing_64
    {
        public class CategoryAttribute : Attribute
        {
            public CategoryAttribute(string value)
            {

            }
        }

        private class UnitTestAttribute : CategoryAttribute
        {
            public UnitTestAttribute(string value)
                : base(value)
            { 

            }
        }

        [TestMethod]
        public void Main() 
        {

        }
    }
}
