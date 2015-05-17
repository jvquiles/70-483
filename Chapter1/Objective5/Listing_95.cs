namespace Chapter1.Objective5
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;

    [TestClass]
    public class Listing_95
    {
        private void Log(Exception logEx)
        {
        }

        private void SomeOperation()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void Main() 
        {
            try
            {
                this.SomeOperation();
            }
            catch (Exception logEx)
            {
                this.Log(logEx);
                throw;
            }
        }
    }
}
