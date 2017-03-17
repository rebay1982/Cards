using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardDeck
{
	class Deck
	{
		private const int deckSize = 52;
		private Card[] cards = new Card[deckSize];

		private int cardsDealt = 0;
		private int cardsArraySize;  // 51 for 0 based indexing.

		public Deck()
		{
			// Initialize the cards array.
			int index = 0;
			var suiteValues = Enum.GetValues(typeof(CardSuite));
			var faceValues = Enum.GetValues(typeof(CardFace));
			foreach(CardSuite suite in suiteValues)
			{
				foreach(CardFace face in faceValues)
				{
					cards[index++] = new Card(suite, face);
				}
			}

			cardsArraySize = cards.Count();
		}

		public void Shuffle()
		{
			Random rnd = new Random();
			Card tempCard;

			for (int index = cardsDealt; index < deckSize; index++)
			{
				int switchIndex = rnd.Next(index, cards.Count());
				tempCard = cards[switchIndex];
				cards[switchIndex] = cards[index];
				cards[index] = tempCard;
			}
		}

		public Card DealOneCard()
		{
			if (cardsDealt > cardsArraySize)
				return null;

			return cards[cardsDealt++];
		}
	}
}
