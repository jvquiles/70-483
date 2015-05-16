namespace Chapter1.Objective5
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;

    [TestClass]
    public class Listing_90
    {
        [TestMethod]
        public void Main() 
        {
            string s = "";

            try
            {
                int i = int.Parse(s);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("You need to enter a value");
            }
            catch (FormatException) 
            {
                Console.WriteLine("{0} is not a valid number. Please try again", s);
            }
        }
    }
}
