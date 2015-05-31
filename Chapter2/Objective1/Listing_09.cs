namespace Chapter2.Objective1
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class Listing_09
    {
        public string MyInstanceField;

        public string Concatenate(string valueToAppend) 
        {
            return MyInstanceField + valueToAppend;
        }

        [TestMethod]
        public void Main() 
        {
            MyInstanceField = "Some New Value";
        }
    }
}
