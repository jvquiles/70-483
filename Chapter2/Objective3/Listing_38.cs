namespace Chapter2.Objective3
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Data.Entity;
    using System.Data.Entity.Core.Objects;

    public interface IObjectContextAdapter
    {
        ObjectContext ObjectContext { get; }
    }

    [TestClass]
    public class Listing_38
    {
        [TestMethod]
        public void Main() 
        {
            DbContext ctx = new DbContext("");
            var context = ((IObjectContextAdapter)ctx).ObjectContext;
        }
    }
}
