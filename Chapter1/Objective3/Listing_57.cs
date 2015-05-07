namespace Chapter1.Objective3
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class Listing_57
    {
        bool x, y;

        [TestMethod]
        public void Main() 
        {
            if (x)
            {
                if (y)
                {
                    F();
                }
                else 
                {
                    G();
                }
            }
        }

        private void G()
        {
        }

        private void F()
        {
        }
    }
}
