namespace Chapter2.Objective1
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class Listing_17
    {
        private class Base 
        {
            public virtual int MyMethod() 
            {
                return 42;
            }
        }

        private class Derived : Base 
        {
            public override int MyMethod()
            {
                return base.MyMethod() * 2;
            }
        }

        [TestMethod]
        public void Main() 
        {
        }
    }
}
