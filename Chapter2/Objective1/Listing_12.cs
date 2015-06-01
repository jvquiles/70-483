namespace Chapter2.Objective1
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class Listing_12
    {
        private class ConstructorChaining 
        {
            private int _p;

            public ConstructorChaining() : this(3) { }
            public ConstructorChaining(int p) 
            {
                this._p = p;
            }
        }

        [TestMethod]
        public void Main() 
        {

        }
    }
}
