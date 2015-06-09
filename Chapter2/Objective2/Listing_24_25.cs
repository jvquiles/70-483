namespace Chapter2.Objective2
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class Listing_24_25
    {
        private class Money 
        {
            public decimal Amount { get; set; }

            public Money(decimal amount)
            {
                this.Amount = amount;
            }

            public static implicit operator decimal(Money money) 
            {
                return money.Amount;
            }

            public static explicit operator int(Money money) 
            {
                return (int)money.Amount;
            }
        }

        [TestMethod]
        public void Main() 
        {
            Money m = new Money(42.42M);
            decimal amount = m;
            int trucatedAmount = (int)m;
        }
    }
}