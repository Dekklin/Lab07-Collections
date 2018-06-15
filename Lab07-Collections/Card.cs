using System;
using System.Collections.Generic;
using System.Text;

namespace Lab07_Collections
{
    public class Card
    {
        public int Number { get; set; }
        public string Color { get; set; }
        public Suit Suit { get; set; }
    }
    public enum  Suit
    {
        Heart,
        Spade,
        Diamond,
        Club
    }
}
