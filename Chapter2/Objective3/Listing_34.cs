namespace Chapter2.Objective3
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class Listing_34
    {
        public class Base 
        {
            private int _privateField = 42;
            protected int _protectedField = 42;

            private void MyPrivateMethod() { }
            protected void MyProtectedMethod() { }
        }

        public class Derived : Base 
        {
            public void MyDerivedMethod() 
            {
                //_privateField = 41;
                _protectedField = 43;

                //MyPrivateMethod();
                MyProtectedMethod();
            }
        }

        [TestMethod]
        public void Main() 
        {

        }
    }
}