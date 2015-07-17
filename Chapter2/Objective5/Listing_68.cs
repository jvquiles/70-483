namespace Chapter2.Objective5
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class Listing_68
    {
        [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
        private class CompleteCustomAttribute : Attribute
        {
            public CompleteCustomAttribute(string description) 
            {
                this.Description = description;
            }

            public string Description { get; set; }
        }

        [TestMethod]
        public void Main() 
        {

        }
    }
}
