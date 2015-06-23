namespace Chapter2.Objective3
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class Listing_39
    {
        private interface InterfaceA         
        {
            void MyMethod();
        }

        private class Implementation : InterfaceA
        {
            void InterfaceA.MyMethod() { }
        }

        [TestMethod]
        public void Main() 
        {

        }
    }
}
