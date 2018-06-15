using System;
using System.Collections.Generic;
using System.Text;

namespace Lab07_Collections
{
    //card construct
    public class Card
    {
        public int Number { get; set; }
        public string Color { get; set; }
        public Suit Suit { get; set; }
    }
    //enum for Suit classes. (Suit is a datatype in this instance)
    public enum  Suit
    {
        Heart,
        Spade,
        Diamond,
        Club
    }
}
