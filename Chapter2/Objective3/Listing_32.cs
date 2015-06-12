namespace Chapter2.Objective3
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class Listing_32
    {
        public class Accessibility 
        {
            private string _myField;

            public string MyProperty 
            {
                get { return this._myField; }
                set { this._myField = value; }
            }
        }

        [TestMethod]
        public void Main() 
        {

        }
    }
}
