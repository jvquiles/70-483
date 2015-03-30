namespace Chapter1.Objective1
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using System.Diagnostics;
    using System.Threading;
    using System.Threading.Tasks;

    [TestClass]
    public class Listing1_19
    {
        [TestMethod]
        public void Main() 
        {
            Stopwatch st = new Stopwatch();
            Console.WriteLine("Start SleepAsyncA");
            st.Start();
            this.SleepAsyncA(1000);
            Console.WriteLine("End SleepAsyncA " + st.ElapsedMilliseconds.ToString());
            
            Console.WriteLine("Start SleepAsyncB");
            st.Restart();
            this.SleepAsyncB(1000);
            Console.WriteLine("End SleepAsyncB " + st.ElapsedMilliseconds.ToString());
        }

        public Task SleepAsyncA(int millisecondsTimeout) 
        {
            return Task.Run(() => Thread.Sleep(millisecondsTimeout));
        }

        public Task SleepAsyncB(int millisecondsTimeout) 
        {
            TaskCompletionSource<bool> tcs = null;
            var t = new Timer(delegate { tcs.TrySetResult(true); }, null, -1, -1);
            tcs = new TaskCompletionSource<bool>(t);
            t.Change(millisecondsTimeout, -1);
            return tcs.Task;
        }
    }
}