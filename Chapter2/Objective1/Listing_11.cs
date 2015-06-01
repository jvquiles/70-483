namespace Chapter2.Objective1
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Collections.Generic;

    [TestClass]
    public class Listing_11
    {
        private class Card
        {
        }

        private class Deck
        {
            private int _maximumNumberOfCards;

            public List<Card> Cards { get; set; }

            public Deck(int maximumNumberOfCards)
            {
                this._maximumNumberOfCards = maximumNumberOfCards;
                Cards = new List<Card>();
            }
        }

        [TestMethod]
        public void Main() 
        {

        }
    }
}
