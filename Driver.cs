using System;

namespace CSharpChallenge
{
    class Driver
    {
        static void Main(string[] args)
        {

            // Creating the card deck instance.
            CardDeck cardDeck = new CardDeck();

            // Peeking at the top of the deck before the shuffle.
            Console.WriteLine(cardDeck.peekTopDeck().toString());

            cardDeck.shuffle();

            // Peeking at the top of the deck after the shuffle.
            Console.WriteLine(cardDeck.peekTopDeck().toString());

            // Dealing every card in the deck and then attempting to over-deal.
            for (int i = 0; i < 53; i++)
            {

                Card drawnCard = cardDeck.deal_one_card();

                if (drawnCard == null)
                {

                    Console.WriteLine("No more cards to draw");

                }
                else
                {

                    Console.WriteLine(drawnCard.toString());

                }

            }

        }

    }

}
