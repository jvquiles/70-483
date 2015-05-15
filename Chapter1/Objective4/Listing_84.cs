namespace Chapter1.Objective4
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;

    [TestClass]
    public class Listing_84
    {
        private class MyArgs : EventArgs
        {
            public int Value { get; set; }

            public MyArgs(int value)
            {
                this.Value = value;
            }
        }

        private class Pub
        {
            public event EventHandler<MyArgs> OnChange = delegate {};

            public void Raise()
            {
                this.OnChange(this, new MyArgs(42));
            }
        }

        private void CreateAndRaise()
        {
            Pub p = new Pub();
            p.OnChange += (sender, e) => { Console.WriteLine("Event raised: {0}", e.Value); };
            p.Raise();
        }

        [TestMethod]
        public void Main() 
        {
            this.CreateAndRaise();
        }
    }
}
