namespace Chapter1.Objective1
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using System.Collections.Concurrent;
    using System.Threading.Tasks;

    [TestClass]
    public class Listing1_28
    {
        [TestMethod]
        public void Main() 
        {
            BlockingCollection<string> col = new BlockingCollection<string>();
            Task read = Task.Run(() => 
            {
                bool seguir = true;
                while (seguir) 
                {
                    Console.WriteLine(col.Take());
                }
            });

            Task write = Task.Run(() => 
            {
                bool seguir = true;
                while (seguir) 
                {
                    string s = "prueba";
                    col.Add(s);
                }
            });
        }
    }
}