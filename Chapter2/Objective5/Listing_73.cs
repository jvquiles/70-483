namespace Chapter2.Objective5
{
    using System;
    using System.Reflection;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class Listing_73
    {
        [TestMethod]
        public void Main() 
        {
            int i = 42;
            MethodInfo compareToMethod = i.GetType().GetMethod("CompareTo", new Type[] { typeof(int) });
            int result = (int)compareToMethod.Invoke(i, new object[] { 41 });
            
            Console.WriteLine(result);
        }
    }
}
