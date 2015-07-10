namespace Chapter2.Objective4
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using System.Collections.Generic;

    [TestClass]
    public class Listing_55
    {
        [TestMethod]
        public void Main() 
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 5, 7, 9 };
            using (List<int>.Enumerator enumerator = numbers.GetEnumerator())
            {
                while(enumerator.MoveNext())
                {
                    Console.WriteLine(enumerator.Current);
                }
            }
        }
    }
}
