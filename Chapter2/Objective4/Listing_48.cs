namespace Chapter2.Objective4
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;

    [TestClass]
    public class Listing_48
    {
        private class Base 
        {
            public void Execute() 
            {
                Console.WriteLine("Base.Execute");
            }            
        }

        private class Derived : Base 
        {
            public new void Execute() 
            {
                Console.WriteLine("Derived.Execute");
            }
        }

        private class Program 
        {
            static internal void Main(string[] args)
            {
                Base b = new Base();
                b.Execute();
                b = new Derived();
                b.Execute();
            }
        }

        [TestMethod]
        public void Main() 
        {
            Program.Main(null);
        }
    }
}
