namespace Chapter2.Objective4
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Collections.Generic;
    using System.Linq;

    [TestClass]
    public class Listing_45
    {
        private interface IEntity 
        {
            int id { get; }
        }

        private class Repository<T>
            where T : IEntity 
        {
            protected IEnumerable<T> elements;

            public Repository(IEnumerable<T> elements)
            {
                this.elements = elements;
            }

            public T FindById(int id) 
            {
                return this.elements.SingleOrDefault(e => e.id == id);
            }
        }

        [TestMethod]
        public void Main() 
        {
            
        }
    }
}
