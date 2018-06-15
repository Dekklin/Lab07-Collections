using System;
using Xunit;
using static Lab07_Collections.Program;
using Lab07_Collections;

namespace XUnitTestProject1
{
    public class UnitTest1
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
            Number = 2,
            Suit = Suit.Spade
        };
        [Fact]
        public void CanAddCard()
        {
            Deck<Card> testDeck = new Deck<Card>() { card1, card2, card3};
                Assert.True(testDeck.Add(card4));
            

        }
        [Fact]
        public void CanRemoveCard()
        {
            Deck<Card> testDeck = new Deck<Card>() { card1, card2, card3};
            Assert.True(testDeck.Remove(card2));
        }
        [Fact]
        public void CantRemoveCard()
        {
            Deck<Card> testDeck = new Deck<Card>() { card1, card2, card3 };
            Assert.False(testDeck.Remove(card4));
        }
        [Fact]
        public void CanTestGetSet()
        {
            Deck<Card> testDeck = new Deck<Card>() { card1, card2, card3 };
            Assert.True(card1.Color == "red");
            Assert.Equal("Club", card1.Suit.ToString());
            Assert.True(card1.Number == 4);
        }
        [Fact]
        public void CanShuffle()
        {
            Deck<Card> testDeck = new Deck<Card>() { card1, card2, card3 };
            Assert.True(testDeck.Shuffle());
        }

    }
}
