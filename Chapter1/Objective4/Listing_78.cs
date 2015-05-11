namespace Chapter1.Objective4
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.IO;

    [TestClass]
    public class Listing_78
    {
        [TestMethod]
        public void Main() 
        {
            ContravarianceDel del = this.DoSomething;
        }

        public delegate void ContravarianceDel(StreamWriter tw);
        public void DoSomething(TextWriter tx) { }
    }
}
