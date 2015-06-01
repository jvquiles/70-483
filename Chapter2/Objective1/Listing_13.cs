namespace Chapter2.Objective1
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;

    [TestClass]
    public class Listing_13
    {
        struct Nullable<T> where T : struct
        {
            private bool hasValue;
            private T value;

            public Nullable(T value) 
            {
                this.hasValue = true;
                this.value = value;
            }

            public bool HasValue { get { return this.HasValue; } }

            public T Value 
            {
                get 
                {
                    if (!this.HasValue) 
                    {
                        throw new ArgumentException();
                    }

                    return this.Value;
                }
            }

            public T GetValueOrDefault() 
            {
                return this.Value;
            }
        }

        [TestMethod]
        public void Main() 
        {
            
        }
    }
}
