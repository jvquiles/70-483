namespace Chapter1.Objective5
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;

    [TestClass]
    public class Listing_92
    {
        [TestMethod]
        public void Main() 
        {
            string s = Console.ReadLine();

            try 
            {
                int i = int.Parse(s);
                if (i == 42) 
                {
                    Environment.FailFast("Special number entered");
                }                
            }
            finally
            {
                Console.WriteLine("Program complete.");
            }

            Console.ReadLine();
        }
    }
}
