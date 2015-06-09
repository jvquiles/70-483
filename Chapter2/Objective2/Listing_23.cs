namespace Chapter2.Objective2
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.IO;

    [TestClass]
    public class Listing_23
    {
        [TestMethod]
        public void Main() 
        {
            object stream = new MemoryStream();
            MemoryStream memoryStream = (MemoryStream)stream;
        }
    }
}
