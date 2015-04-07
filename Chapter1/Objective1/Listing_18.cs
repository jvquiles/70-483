namespace Chapter1.Objective1
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using System.Net.Http;
    using System.Threading.Tasks;

    [TestClass]
    public class Listing_18
    {
        [TestMethod]
        public void Main() 
        {
            string result = DownloadContent().Result;
            Console.WriteLine(result);

            // Wait until finish
            Console.ReadLine();
        }

        public static async Task<string> DownloadContent() 
        {
            using (HttpClient client = new HttpClient())
            {
                string result = await client.GetStringAsync("http://www.microsoft.com");
                return result;
            }
        }
    }
}