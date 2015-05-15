namespace Chapter1.Objective4
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;

    [TestClass]
    public class Listing_86
    {
        private class Pub 
        {
            public event EventHandler OnChange = delegate { };

            public void Raise() 
            {
                this.OnChange(this, EventArgs.Empty);
            }
        }

        private void CreateAndRaise() 
        {
            Pub p = new Pub();

            p.OnChange += (sender, e) => { Console.WriteLine("Subscriber 1 called"); };

            p.OnChange += (sender, e) => { throw new Exception(); };

            p.OnChange += (sender, e) => { Console.WriteLine("Subscriber 3 called"); };

            p.Raise();
        }

        [TestMethod]
        public void Main() 
        {
            this.CreateAndRaise();
        }
    }
}
