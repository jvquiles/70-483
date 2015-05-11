namespace Chapter1.Objective4
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.IO;

    [TestClass]
    public class Listing_77
    {
        [TestMethod]
        public void Main() 
        {
            ConvarianceDel del;
            del = this.MethodStream;
            del = this.MethodString;
        }
        
        public delegate TextWriter ConvarianceDel();
        public StreamWriter MethodStream() { return null; }
        public StringWriter MethodString() { return null; }
    }
}
