using System;
namespace HIC_Tech
{
	public class CardDeck
	{
		private Card[] deck;
		private readonly int deckSize = 52;
		private readonly string[] suits = { "Diamonds", "Clubs", "Hearts", "Spades" };
		private readonly string[] faceValues = { "A", "K", "Q", "J", "10", "9", "8", "7", "6", "5", "4", "3", "2" };
		private Random randomNum;
		private int dealCount = -1;

		public CardDeck()
		{
			deck = new Card[deckSize];
			for (int i = 0; i < deckSize; i++)
			{
				int faceIndex = i % 13;
				int suitIndex = i / 13;
				deck[i] = new Card(faceValues[faceIndex], suits[suitIndex]);
			}
			randomNum = new Random();
		}

		public Card[] Deck
        {
			get { return deck; }
			set { deck = value; }
		}

		public void Shuffle()
		{
			dealCount = 0;
			for(int j = 0; j < deckSize; j++)
            {
				int randomIndex = randomNum.Next(deckSize);
                (deck[randomIndex], deck[j]) = (deck[j], deck[randomIndex]);
            }
        }

        public void Sort()
        {
			dealCount = 0;
			for (int k = 0; k < deckSize; k++)
			{
				if (deck[k].FaceValue == faceValues[k % 13] && deck[k].Suit == suits[k / 13])
					continue;
				else
                {
					Card findSwap = Array.Find(deck, card => card.FaceValue == faceValues[k % 13] && card.Suit == suits[k / 13]);
					int swapIndex = Array.IndexOf(deck, findSwap);
                    (deck[swapIndex], deck[k]) = (deck[k], deck[swapIndex]);
                }
            }
        }

		public Card DealTopCard()
        {
			dealCount++;
			return deck[dealCount];	
        }
    }
}

