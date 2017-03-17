using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardDeck
{
	class Deck
	{
		private Card[] cards = new Card[52];

		private int cardsDealt = 0;
		private int deckSize = 51;  // 51 for 0 based indexing.

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
		}

		public void Shuffle()
		{
			Random rnd = new Random();
			Card tempCard;

			for (int index = 0; index <= deckSize; index++)
			{
				int switchIndex = rnd.Next(index, cards.Count());
				tempCard = cards[switchIndex];
				cards[switchIndex] = cards[index];
				cards[index] = tempCard;
			}
		}

		public Card DealOneCard()
		{
			if (cardsDealt > deckSize)
				return null;

			return cards[deckSize - cardsDealt++];
		}
	}
}
