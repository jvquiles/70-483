namespace Chapter2.Objective4
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;
using System.Collections.Generic;

    [TestClass]
    public class Listing_56
    {
        private class Person 
        {
            public Person(string firstName, string lastName) 
            {

            }

            public string FirstName { get; set; }
            public string LastName { get; set; }

            public override string ToString()
            {
                return this.FirstName + " " + this.LastName;
            }
        }

        private class People : IEnumerable<Person> 
        {
            public People(Person[] people) 
            {
                this.people = people;
            }

            public Person[] people;

            public IEnumerator<Person> GetEnumerator() 
            {
                for (int index = 0; index < this.people.Length; index++) 
                {
                    yield return this.people[index];
                }
            }

            public IEnumerator IEnumerable.GetEnumerator() 
            {
                return this.GetEnumerator();
            }
        }

        [TestMethod]
        public void Main() 
        {

        }
    }
}
