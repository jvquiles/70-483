namespace Chapter1.Objective3
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class Listing_50
    {
        [TestMethod]
        public void Main() 
        {
            this.Process(null);
        }

        private void Process(string input) 
        {
            bool result = (input != null) && (input.StartsWith("v"));
        }
    }
}
