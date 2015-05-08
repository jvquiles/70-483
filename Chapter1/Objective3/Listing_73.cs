namespace Chapter1.Objective3
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Collections.Generic;

    [TestClass]
    public class Listing_73
    {
        [TestMethod]
        public void Main() 
        {
            var people = new List<Person>()
            {
                new Person() { FirstName = "Johm", LastName = "Doe" },
                new Person() { FirstName = "Jane", LastName = "Doe" }
            };

            List<Person>.Enumerator e = people.GetEnumerator();

            try 
            {
                Person v;
                while (e.MoveNext())
                {
                    v = e.Current;
                }
            }
            finally
            {
                System.IDisposable d = e as System.IDisposable;
                if (d != null)
                {
                    d.Dispose();
                }
            }
        }
    }
}
