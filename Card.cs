using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardDeck
{
	public enum CardSuite
	{
		HEARTS,
		SPADES,
		CLUBS,
		DIAMONDS
	};

	public enum CardFace
	{
		ACE,
		TWO,
		THREE,
		FOUR,
		FIVE,
		SIX,
		SEVEN,
		EIGHT,
		NINE,
		TEN,
		JACK,
		QUEEN,
		KING
	};


	class Card
	{
		private CardSuite suite;
		private CardFace face;

		public Card(CardSuite suite, CardFace face)
		{
			this.suite = suite;
			this.face = face;
		}


		public override string ToString()
		{
			return "Suite: " + suite.ToString() + "; Face: " + face.ToString();
		}
	}
}
