namespace Chapter1.Objective5
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;

    [TestClass]
    public class Listing_89
    {
        [TestMethod]
        public void Main() 
        {
            while(true)
            {
                string s = Console.ReadLine();

                if (string.IsNullOrEmpty(s))
                {
                    break;
                }

                try 
                {
                    int i = int.Parse(s);
                    //break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("{0} is not a valid number. Please try again", s);
                    Console.ReadLine();
                }
            }
        }
    }
}
