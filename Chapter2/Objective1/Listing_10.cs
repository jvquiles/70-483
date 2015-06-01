﻿namespace Chapter2.Objective1
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Collections.Generic;
    using System.Linq;

    [TestClass]
    public class Listing_10
    {

        private class Card
        {
        }

        private class Deck 
        {
            public ICollection<Card> Cards { get; private set; }
            
            private Card this[int index] 
            {
                get { return Cards.ElementAt(index); }
            }
        }

        [TestMethod]
        public void Main() 
        {

        }
    }
}
