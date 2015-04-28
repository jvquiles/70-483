namespace Chapter1.Objective3
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class Listing_49
    {
        [TestMethod]
        public void Main() 
        {
            int value = 42;
            bool result = (0 < value) && (value < 100);
        }
    }
}
