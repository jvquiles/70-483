namespace Chapter2.Objective1
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    public static class MyExtensions
    {
        public static decimal Discount(this Product product)
        {
            return product.Price * .9M;
        }
    }

    public class Product
    {
        public decimal Price { get; set; }
    }

    [TestClass]
    public class Listing_16
    {
        public class Calculator 
        {
            private decimal CalculateDiscount(Product p) 
            {
                return p.Discount();
            }
        }

        [TestMethod]
        public void Main() 
        {

        }
    }
}