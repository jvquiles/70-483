namespace Chapter2.Objective6
{
    using System.IO;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class Listing_80
    {
        [TestMethod]
        public void Main() 
        {
            StreamWriter stream = File.CreateText("temp.dat");
            stream.Write("some data");

            File.Delete("temp.dat");
        }
    }
}
