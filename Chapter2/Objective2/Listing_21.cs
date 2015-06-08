namespace Chapter2.Objective2
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using System.Net.Http;

    [TestClass]
    public class Listing_21
    {
        [TestMethod]
        public void Main() 
        {
            HttpClient client = new HttpClient();
            object o = client;
            IDisposable d = client;
        }
    }
}
