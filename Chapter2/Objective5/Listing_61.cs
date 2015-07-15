namespace Chapter2.Objective5
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;

    [TestClass]
    public class Listing_61
    {
        [Serializable]
        private class Person 
        {

        }

        [TestMethod]
        public void Main() 
        {
            if (Attribute.IsDefined(typeof(Person), typeof(SerializableAttribute)))
            {

            }
        }
    }
}
