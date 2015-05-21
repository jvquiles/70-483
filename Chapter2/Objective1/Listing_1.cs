namespace Chapter2.Objective1
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class Listing_1
    {
        private enum Days 
        {
            None = 0x0,
            Sunday = 0x1,
            Monday = 0x2,
            Tuesday = 0x4,
            Wednesday = 0x8,
            Thursday = 0x10,
            Friday = 0x20,
            Saturday = 0x40,
        }

        [TestMethod]
        public void Main() 
        {
            Days readingDays = Days.Monday | Days.Saturday;
        }
    }
}
