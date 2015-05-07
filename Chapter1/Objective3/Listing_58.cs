namespace Chapter1.Objective3
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class Listing_58    
    {
        [TestMethod]
        public void Main()
        {
            int? x = null;
            int y = x ?? -1;
        }
    }
}
