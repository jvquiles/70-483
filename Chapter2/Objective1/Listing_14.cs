namespace Chapter2.Objective1
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class Listing_14
    {
        private class MyClass<T> 
            where T: class, new()
        {
            public MyClass() 
            {
                MyProperty = new T();
            }

            private T MyProperty { get; set; }
        }

        [TestMethod]
        public void Main() 
        {

        }
    }
}
