namespace Chapter1.Objective3
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;

    [TestClass]
    public class Listing_65
    {
        [TestMethod]
        public void Main()
        {
            int[] values = { 1, 2, 3, 4, 5, 6 };
            for (int x = 0, y = values.Length - 1; ((x < values.Length) && y >= 0); x++, y-- )
            {
                Console.Write(values[x]);
                Console.Write(values[y]);
            }
        }
    }
}