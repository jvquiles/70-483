namespace Chapter1.Objective4
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;

    [TestClass]
    public class Listing_83
    {
        private class Pub
        {
            public event Action OnChange = delegate { };

            public void Raise()
            {
                OnChange();
            }
        }

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
