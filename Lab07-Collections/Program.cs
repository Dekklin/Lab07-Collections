using System;
using Lab07_Collections;

namespace Lab07_Collections
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            PopulateDeck();
            Console.ReadKey();
        }

        static void PopulateDeck()
        {
            Card card1 = new Card()
            {
                Color = "red",
                Number = 4,
                Suit = Suit.Club
            };
            Card card2 = new Card()
            {
                Color = "black",
                Number = 6,
                Suit = Suit.Diamond
            };
            Card card3 = new Card()
            {
                Color = "red",
                Number = 8,
                Suit = Suit.Club
            };
            Card card4 = new Card()
            {
                Color = "black",
                Suit = Suit.Spade,
                Number = 7
            };
            Card card5 = new Card()
            {
                Color = "red",
                Suit = Suit.Heart,
                Number = 7
            };
            Card card6 = new Card()
            {
                Color = "black",
                Suit = Suit.Spade,
                Number = 8
            };
            Card card7 = new Card()
            {
                Color = "red",
                Suit = Suit.Diamond,
                Number = 4
            };
            Card card8 = new Card()
            {
                Color = "red",
                Suit = Suit.Heart,
                Number = 5
            };
            Card card9 = new Card()
            {
                Color = "black",
                Suit = Suit.Heart,
                Number = 9
            };
            Card card10 = new Card()
            {
                Color = "black",
                Suit = Suit.Club,
                Number = 9
            };
            Card card11 = new Card()
            {
                Color = "black",
                Suit = Suit.Diamond,
                Number = 7
            };
            Card card12 = new Card()
            {
                Color = "black",
                Suit = Suit.Heart,
                Number = 7
            };
            Card card13 = new Card()
            {
                Color = "black",
                Suit = Suit.Heart,
                Number = 7
            };
            Card card14 = new Card()
            {
                Color = "black",
                Suit = Suit.Heart,
                Number = 7
            };
            Card card15 = new Card()
            {
                Color = "black",
                Suit = Suit.Diamond,
                Number = 10
            };

            Deck<Card> myCards = new Deck<Card>() { card1, card2, card3, card4, card5, card5, card6, card7, card8, card9, card10, card11, card12, card13, card14, card15 };
            foreach(Card card in myCards)
            {
                Console.WriteLine(card.Suit);
            }
            myCards.Remove(card1);

            myCards.Shuffle();
            int y = 0;
            foreach (Card Card in myCards)
            {
                    y++;
                if (Card != null)
                {
                    Console.WriteLine($"#{y} -- {Card.Color}");
                }
            }
        }   
    }
}
