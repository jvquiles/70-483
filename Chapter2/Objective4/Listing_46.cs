namespace Chapter2.Objective4
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Collections.Generic;
    using System.Linq;
    
    [TestClass]
    public class Listing_46
    {
        private interface IEntity 
        {
            int Id { get; }
        }

        private class Order : IEntity 
        {
            private int id;

            public int Id {
                get 
                {
                    return this.id;
                }
            }
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
                return this.elements.SingleOrDefault(x => x.Id == id);
            }
        }

        private class OrderRepository : Repository<Order>
        {
            public OrderRepository(IEnumerable<Order> orders) 
                : base(orders)
            {
            }

            public IEnumerable<Order> FilterOrderOnAmount(decimal amount)
            {
                List<Order> result = null;
                return result;
            }
        }

        [TestMethod]
        public void Main() 
        {

        }
    }
}
