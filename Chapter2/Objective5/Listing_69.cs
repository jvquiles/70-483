namespace Chapter2.Objective5
{
    using Microsoft.Office.Interop.Excel;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class Listing_69
    {
        private interface IPlugin 
        {
            string Name { get; }
            string Description { get; }
            bool Load(Application myapplication);
        }

        [TestMethod]
        public void Main() 
        {

        }
    }
}
