namespace Chapter2.Objective1
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class Listing_18
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
            public sealed override int MyMethod()
            {
                return base.MyMethod() * 2;
            }
        }

        private class Derived2 : Derived 
        {
            // This line would give a compile error
            //public override int MyMethod()
            //{
            //    return 1;
            //}
        }

        [TestMethod]
        public void Main() 
        {

        }
    }
}
