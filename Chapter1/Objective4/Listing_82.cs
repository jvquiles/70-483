namespace Chapter1.Objective4
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;

    public class Pub
    {
        public Action OnChange { get; set; }

        public void Raise()
        {
            if (this.OnChange != null)
            {
                this.OnChange();
            }
        }
    }

    [TestClass]
    public class Listing_82
    {
        [TestMethod]
        public void Main() 
        {
            this.CreateAndRaise();
        }

        public void CreateAndRaise() 
        {
            Pub p = new Pub();
            p.OnChange += () => Console.WriteLine("Event raised to mehtod 1");
            p.OnChange += () => Console.WriteLine("Event raised to mehtod 2");
            p.Raise();
        }
    }
}
