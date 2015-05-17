namespace Chapter1.Objective5
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;

    [TestClass]
    public class Listing_96
    {
        public class OrderProcessingException : Exception 
        {
            private string p;
            private Exception ex;

            public OrderProcessingException(string p, Exception ex)
            {
                this.p = p;
                this.ex = ex;
            }
        }

        private void ProcessOrder()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void Main() 
        {
            try 
            {
                this.ProcessOrder();
            }
            catch (NotImplementedException ex)
            {
                throw new OrderProcessingException("Error while processing order", ex);
            }
        }
    }
}
