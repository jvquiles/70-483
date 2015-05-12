namespace Chapter1.Objective4
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;

    public class Pub2 
    {
        public event Action OnChange = delegate { };

        public void Raise() 
        {
            OnChange();
        }
    }

    [TestClass]
    public class Listing_83
    {
        [TestMethod]
        public void Main()
        {
            this.CreateAndRaise();
        }

        public void CreateAndRaise()
        {
            Pub2 p = new Pub2();
            p.OnChange += () => Console.WriteLine("Event raised to mehtod 1");
            p.OnChange += () => Console.WriteLine("Event raised to mehtod 2");
            p.Raise();
        }
    }
}
