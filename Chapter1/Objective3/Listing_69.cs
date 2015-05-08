namespace Chapter1.Objective3
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;

    [TestClass]
    public class Listing_69
    {
        [TestMethod]
        public void Main()
        {
            int[] values = { 1, 2, 3, 4, 5, 6 };

            {
                int index = 0;
                while (index < values.Length)
                {
                    Console.Write(values[index]);
                    index++;
                }
            }
        }
    }
}
