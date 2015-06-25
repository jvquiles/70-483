namespace Chapter2.Objective4
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Collections.Generic;

    [TestClass]
    public class Listing_43
    {
        private interface IRepository<T> 
        {
            T FindById(int id);
            IEnumerable<T> All();
        }

        [TestMethod]
        public void Main() 
        {

        }
    }
}
