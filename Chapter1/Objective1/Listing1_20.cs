namespace Chapter1.Objective1
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using System.Windows;

    [TestClass]
    public class Listing1_20
    {
        [TestMethod]
        public void Main() 
        {
            this.Button_Click();
        }

        private async void Button_Click()
        { 
            HttpClient httpClient = new HttpClient();

            string content = await httpClient
                .GetStringAsync("http://microsoft.com")
                    .ConfigureAwait(false);

            string output = content;
        }
    }
}