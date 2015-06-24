namespace Chapter2.Objective4
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;

    [TestClass]
    public class Listing_42
    {
        interface IReadOnlyInterface 
        {
            int Value { get; }
        }

        struct ReadAndWriteImplementation : IReadOnlyInterface 
        {
            public int Value { get; set; }
        }

        [TestMethod]
        public void Main() 
        {

        }
    }
}
