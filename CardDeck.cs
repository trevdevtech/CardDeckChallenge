using System.Collections.Generic;
using System;

namespace CSharpChallenge
{

    enum Suits { Hearts, Diamonds, Clubs, Spades };

    enum Ranks { Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, King, Queen, Ace };

    class Card
    {

        public Suits suit;

        public Ranks rank;

        public String toString()
        {

            return "card is " + rank + " of " + suit;

        }

    };

    class CardDeck
    {

        private List<Card> cards;

        public CardDeck()
        {

            cards = new List<Card>();

            Card tempCard;

            Random rand = new Random();

            Array ranks = Enum.GetValues(typeof(Ranks));

            Array suits = Enum.GetValues(typeof(Suits));

            // Initializing the card list with a card for every suit for each rank.
            for (int i = 0; i < suits.Length; i++)
            {

                for (int j = 0; j < ranks.Length; j++)
                {

                    tempCard = new Card();

                    tempCard.suit = (Suits)ranks.GetValue(i);

                    tempCard.rank = (Ranks)ranks.GetValue(j);

                    cards.Add(tempCard);

                }
            }
        }

        public Card peekTopDeck()
        {

            return cards[0];

        }

        public void shuffle()
        {

            Random rand = new Random();

            // Loop houses logic for swapping each card with a randomly choosen card.
            for (int i = 0; i < cards.Count; i++)
            {

                Card tempCard = cards[i];

                int randIndex = rand.Next(cards.Count);

                cards[i] = cards[randIndex];

                cards[randIndex] = tempCard;

            }

        }

        public Card deal_one_card()
        {

            if (cards.Count <= 0)
            {

                return null;

            }

            Random rand = new Random();

            int dealIndex = rand.Next(cards.Count);

            Card cardToDeal = cards[dealIndex];

            cards.RemoveAt(dealIndex);

            return cardToDeal;

        }

    }
}