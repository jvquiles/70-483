namespace Chapter2.Objective4
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;

    [TestClass]
    public class Listing_41
    {
        interface IExample 
        {
            string GetResult();
            int Value { get; set; }
            event EventHandler ResultRetrieved;
            int this[string index] { get; set; }
        }

        private class ExampleImplementation : IExample 
        {
            public string GetResult() 
            {
                return "result";
            }

            public int Value { get; set; }

            public event EventHandler CalculationPeformed;

            public event EventHandler ResultRetrieved;

            public int this[string index] 
            {
                get 
                {
                    return 42;
                }

                set { }
            }
        }

        [TestMethod]
        public void Main() 
        {

        }
    }
}
