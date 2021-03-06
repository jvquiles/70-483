﻿namespace Chapter1.Objective1
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    [TestClass]
    public class Listing_09
    {
        [TestMethod]
        public void Main() 
        {
            Task<int> t = Task.Run(() => 
            {
                return 42;
            });

            Console.WriteLine(t.Result);

            // Wait until finish
            Console.ReadLine();
        }
    }
}
