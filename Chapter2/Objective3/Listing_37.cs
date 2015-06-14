namespace Chapter2.Objective3
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;

    [TestClass]
    public class Listing_37
    {
        private class Person 
        {
            private string _firstName;

            public string FirstName 
            {
                get { return this._firstName; }
                set 
                {
                    if (string.IsNullOrEmpty(value)) 
                    {
                        throw new ArgumentException();
                    }

                    this._firstName = value;
                }
            }
        }

        [TestMethod]
        public void Main() 
        {

        }
    }
}
