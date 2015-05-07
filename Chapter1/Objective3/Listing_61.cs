namespace Chapter1.Objective3
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;

    [TestClass]
    public class Listing_61
    {
        [TestMethod]
        public void Main() 
        {
            this.Check(Console.ReadLine());
            Console.ReadLine();
        }

        private void Check(string input)
        {
            if (input == "a"
                || input == "e"
                || input == "i"
                || input == "o"
                || input == "u")
            {
                Console.WriteLine("Input is a vowel");
            }
            else 
            {
                Console.WriteLine("Input is a consonant");
            }
        }
    }
}
