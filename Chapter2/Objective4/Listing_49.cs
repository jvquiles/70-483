namespace Chapter2.Objective4
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class Listing_49
    {
        private abstract class Base
        {
            public virtual void MethodWithImplementation()
            {
                Console.WriteLine("Method with implementation");
            }

            public abstract void AbstractMethod();
        }
        private class Derived : Base
        {
            public override void AbstractMethod() { }
        }

        [TestMethod]
        public void Main() 
        {

        }
    }
}
