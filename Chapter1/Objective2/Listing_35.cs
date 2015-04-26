namespace Chapter1.Objective2
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using System.Threading.Tasks;

    [TestClass]
    public class Listing1_35
    {
        [TestMethod]
        public void Main() 
        {
            int n = 0;
            var up = Task.Run(() => 
            {
                for (int i = 0; i < 1000000; i++) 
                {
                    n++;
                }
            });

            for (int i = 0; i < 1000000; i++) 
            {
                n--;
            }

            up.Wait();
            Console.WriteLine(n);
        }
    }
}
