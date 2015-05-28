namespace Chapter2.Objective1
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class Listing_3
    {
        public class Program 
        {
            public static void Main(string[] args) 
            {
                System.Console.WriteLine("I'm calling a method!");
                System.Console.ReadLine();
            }
        } 

        [TestMethod]
        public void Main() 
        {
            Program.Main(null);
        }
    }
}
