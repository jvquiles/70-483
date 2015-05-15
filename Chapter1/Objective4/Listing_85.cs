namespace Chapter1.Objective4
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
        
    [TestClass]
    public class Listing_85
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
            private event EventHandler<MyArgs> onChange = delegate { };
            public event EventHandler<MyArgs> OnChange 
            {
                add 
                {
                    lock (onChange) 
                    {
                        onChange += value;
                    }
                }

                remove
                {
                    lock (onChange)
                    {
                        onChange -= value;
                    }
                }
            }

            public void Raise() 
            {
                onChange(this, new MyArgs(42));
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
