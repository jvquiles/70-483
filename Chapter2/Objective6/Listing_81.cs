namespace Chapter2.Objective6
{
    using System;
    using System.IO;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class Listing_81
    {
        [TestMethod]
        public void Main() 
        {
            StreamWriter stream = File.CreateText("temp.dat");
            stream.Write("some data");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            File.Delete("delete.dat");
        }
    }
}
