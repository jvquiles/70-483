namespace Chapter1.Objective2
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Threading;
    
    [TestClass]
    public class Listing_38
    {
        [TestMethod]
        public void Main() 
        {
            object gate = new object();
            bool lockTaken = false;

            try
            {
                Monitor.Enter(gate, ref lockTaken);
            }
            finally 
            {
                if (lockTaken)
                {
                    Monitor.Exit(gate);
                }
            }
        }
    }
}
