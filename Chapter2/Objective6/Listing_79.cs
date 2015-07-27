namespace Chapter2.Objective6
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class Listing_79
    {
        private class SomeType 
        {
            ~SomeType() 
            {
                // This code is called when the finalize method executes
            }
        }

        [TestMethod]
        public void Main ()
        {

        }
    }
}
