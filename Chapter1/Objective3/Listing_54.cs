namespace Chapter1.Objective3
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class Listing_54
    {
        [TestMethod]
        public void Main() 
        {
            bool b = true;
            if (b) 
            {
                int r = 42;
                b = false;
            }
        }
    }
}
