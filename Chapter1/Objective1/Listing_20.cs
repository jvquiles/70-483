namespace Chapter1.Objective1
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    [TestClass]
    public class Listing_20
    {
        [TestMethod]
        public void Main() 
        {
            this.Button_Click();

            // Wait until finish
            Console.ReadLine();
        }

        private async void Button_Click()
        { 
            HttpClient httpClient = new HttpClient();

            string content = await httpClient
                .GetStringAsync("http://microsoft.com")
                    .ConfigureAwait(false);

            Console.WriteLine(content);
        }
    }
}