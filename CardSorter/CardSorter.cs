using System.Collections.Generic;
using System.Linq;

namespace CardSorter
{
    public static class CardSorter
    {
        public static IEnumerable<Card> Sort(IEnumerable<Card> cards)
        {
            var firstCard = cards.Select(m => m.From).Except(cards.Select(m => m.To)).First();

            var cardsDictionary = cards.ToDictionary(k => k.From, v => v);

            var sortedCards = new List<Card>(cardsDictionary.Count)
            {
                cardsDictionary[firstCard]
            };

            for (int i = 1; i < cardsDictionary.Count; ++i)
            {
                sortedCards.Add(cardsDictionary[sortedCards[i-1].To]);
            }

            return sortedCards;
        }
    }
}
