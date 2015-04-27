namespace Chapter1.Objective2
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using System.Threading.Tasks;

    [TestClass]
    public class Listing_39b
    {
        private static volatile int flag = 0;
        private static int value = 0;

        [TestMethod]
        public void Main() 
        {
            var run1 = Task.Run(() => 
            {
                this.Thread1();
            });

            var run2 = Task.Run(() => 
            {
                this.Thread2();
            });

            run1.Wait();
            run2.Wait();
        }

        public void Thread1() 
        {
            value = 5;
            flag = 1;
        }

        public void Thread2() 
        {
            if (flag == 1) 
            {
                Console.WriteLine(value);
            }
        }
    }
}
