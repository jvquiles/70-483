namespace Chapter2.Objective2
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class Listing_19
    {
        [TestMethod]
        public void Main() 
        {
            int i = 42;
            object o = i;
            int x = (int)o;
        }
    }
}