namespace Chapter1.Objective3
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class Listing_60
    {
        [TestMethod]
        public void Main() 
        {
            GetValue(true);
        }

        private static int GetValue(bool p)
        {
            if (p)
            {
                return 1;
            }
            else 
            {             
                return 0;
            }

            return p ? 1 : 0;
        }
    }
}
