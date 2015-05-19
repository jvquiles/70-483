namespace Chapter1.Objective5
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using System.Runtime.ExceptionServices;

    [TestClass]
    public class Listing_97
    {
        [TestMethod]
        public void Main() 
        {
            ExceptionDispatchInfo possibleException = null;

            try 
            {
                string s = Console.ReadLine();
                int.Parse(s);
            }
            catch (FormatException ex)
            {
                possibleException = ExceptionDispatchInfo.Capture(ex);
            }

            if (possibleException != null)
            {
                possibleException.Throw();
            }
        }
    }
}
