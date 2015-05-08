namespace Chapter1.Objective3
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Collections.Generic;

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    [TestClass]
    public class Listing_72
    {
        [TestMethod]
        public void Main() 
        {
            var people = new List<Person>()
            {
                new Person() { FirstName = "Johm", LastName = "Doe" },
                new Person() { FirstName = "Jane", LastName = "Doe" }
            };

            foreach(Person p in people)
            {
                p.LastName = "Changed";
            }
        }
    }
}
