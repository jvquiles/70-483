﻿namespace Chapter1.Objective1
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using System.Threading;

    [TestClass]
    public class Listing_02
    {
        static void ThreadMethod()
        {
            for (int i = 0; i < 20; i++) 
            {
                Console.WriteLine("ThreadProc: {0}", i);
                Thread.Sleep(1000);
            }
        }

        [TestMethod]
        public void Main() 
        {
            Thread t = new Thread(new ThreadStart(ThreadMethod));
            t.IsBackground = true; 
            t.Start();

            // Wait until finish
            Console.ReadLine();
        }
    }
}
