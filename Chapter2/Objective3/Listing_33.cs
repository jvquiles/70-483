namespace Chapter2.Objective3
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class Listing_33
    {
        public class Accessibility 
        {
            private string[] _myfield;

            public string MyProperty 
            {
                get { return this._myfield[0]; }
                set { this._myfield[0] = value; }
            }        
        }

        [TestMethod]
        public void Main() 
        {

        }
    }
}
