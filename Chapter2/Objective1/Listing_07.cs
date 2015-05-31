namespace Chapter2.Objective1
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class Listing_07
    {
        private void MyMethod(int FirstArgument, string secondArgument = "default value", bool thirdArgument = false)
        {
        }

        [TestMethod]
        public void Main() 
        {
            this.MyMethod(1, thirdArgument: true);
        }
    }
}
