namespace Chapter1.Objective1
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using System.Linq;

    [TestClass]
    public class Listing_27
    {
        [TestMethod]
        public void Main() 
        {
            var numbers = Enumerable.Range(0, 20);
            try
            {
                var paralelelResult = numbers.AsParallel()
                    .Where(i => IsEven(i));

                paralelelResult.ForAll(e => Console.WriteLine(e));
            }
            catch (AggregateException ex) 
            {
                Console.WriteLine("There where {0} exceptions", ex.InnerExceptions.Count);
            }

            // Wait until finish
            Console.ReadLine();
        }

        public static bool IsEven(int i)
        {
            if (i % 10 == 0) throw new ArgumentException("i");

            return i % 2 == 0;
        }
    }
}