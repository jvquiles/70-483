namespace Chapter1.Objective3
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
 
    [TestClass]
    public class Listing_59
    {
        [TestMethod]
        public void Main()
        {
            int? x = null;
            int? z = null;
            int y = x ?? z ?? -1;
        }
    }
}
