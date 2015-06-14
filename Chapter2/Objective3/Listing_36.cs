namespace Chapter2.Objective3
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class Listing_36
    {
        private int _field;

        public void SetValue(int value) 
        {
            this._field = value;
        }

        public int GetValue() 
        {
            return this._field;
        }

        [TestMethod]
        public void Main() 
        {

        }
    }
}
