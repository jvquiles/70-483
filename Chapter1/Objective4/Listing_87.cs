namespace Chapter1.Objective4
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    [TestClass]
    public class Listing_87
    {
        private class Pub 
        {
            public event EventHandler OnChange = delegate { };

            public void Raise() 
            {
                var exceptions = new List<Exception>();

                foreach(Delegate handler in this.OnChange.GetInvocationList())
                {
                    try
                    {
                        handler.DynamicInvoke(this, EventArgs.Empty);
                    }
                    catch (Exception ex) 
                    {
                        exceptions.Add(ex);
                    }
                }

                if (exceptions.Any()) 
                {
                    throw new AggregateException(exceptions);
                }
            }
        }

        private void CreateAndRaise() 
        {
            Pub p = new Pub();

            p.OnChange += (sender, e) => { Console.WriteLine("Subscriber 1 called"); };

            p.OnChange += (sender, e) => { throw new Exception(); };

            p.OnChange += (sender, e) => { Console.WriteLine("Subscriber 2 called"); };

            try
            {
                p.Raise();
            }
            catch (AggregateException ex) 
            {
                Console.WriteLine(ex.InnerExceptions.Count);
            }
        }

        [TestMethod]
        public void Main() 
        {
            this.CreateAndRaise();
        }
    }
}
