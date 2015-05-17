namespace Chapter1.Objective5
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using System.IO;

    [TestClass]
    public class Listing_94
    {
        private string OpenAndParse(string fileName)
        {
            if (string.IsNullOrEmpty(fileName)) 
            {
                throw new ArgumentException("FileName:", "Filename is required");
            }

            return File.ReadAllText(fileName);
        }

        [TestMethod]
        public void Main() 
        {
            this.OpenAndParse(Console.ReadLine());
            Console.ReadLine();
        }
    }
}
