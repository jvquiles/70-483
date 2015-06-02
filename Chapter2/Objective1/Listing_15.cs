namespace Chapter2.Objective1
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class Listing_15
    {
        public void MyGenericMethod<T>() 
        {
            T defaultValue = default(T);
        }

        [TestMethod]
        public void Main() 
        {

        }
    }
}
