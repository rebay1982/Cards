using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardDeck
{
	class Program
	{
		static void Main(string[] args)
		{

			Deck deck = new Deck();
			deck.Shuffle();

			for (int i = 0; i < 52; i++)
			{
				Console.WriteLine("Card " + i + " " + deck.DealOneCard().ToString());
			}
		}
	}
}
