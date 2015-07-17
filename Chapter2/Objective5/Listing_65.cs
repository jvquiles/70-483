namespace Chapter2.Objective5
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Xunit;

    [TestClass]
    public class Listing_65
    {
        private class CategoryAttribute : Attribute
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

        [Fact]
        [UnitTest("")]
        public void MySecondUnitTest() 
        {

        }

        [TestMethod]
        public void Main() 
        {

        }
    }
}
