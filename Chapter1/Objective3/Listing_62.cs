namespace Chapter1.Objective3
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;

    [TestClass]
    public class Listing_62
    {
        [TestMethod]
        public void Main() 
        {
            this.CheckWithSwitch(Console.ReadKey().KeyChar);
            Console.ReadLine();
        }

        private void CheckWithSwitch(char input) 
        {
            switch (input)
            {
                case 'a':
                case 'b':
                case 'i':
                case 'o':
                case 'u':
                    {
                        Console.WriteLine("Input is a vowel");
                        break;
                    }
                case 'y':
                    {
                        Console.WriteLine("Input is sometimes a vowel");
                        break;
                    }
                default:                    
                    {
                        Console.WriteLine("Input is consonant");
                        break;
                    }
            }
        }
    }
}
