using CardSorter;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace CardSorterTest
{
    [TestClass]
    public class CardSorterTest
    {
        [TestMethod]
        public void SortTest()
        {
            var cards = new List<Card> 
            { 
                new Card { From = "Moscow", To = "Paris" },
                new Card { From = "Cologne", To = "Moscow" },
                new Card { From = "Melbourne", To = "Cologne" }, 
                
            };

            var sortedCards = CardSorter.CardSorter.Sort(cards).ToList();

            for (int i = 0; i < sortedCards.Count - 1; ++i )
            {
                Assert.AreEqual(sortedCards[i].To, sortedCards[i + 1].From);
            }
        }
    }
}
