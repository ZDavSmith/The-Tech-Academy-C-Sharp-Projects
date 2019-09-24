using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public struct Card //public lets it be accessable.. Also, valid struct type since we wouldn't want the value of the card to change
    {
      public Suit Suit { get; set; } //card class has a property of datatype string, called Suit. You can either "get" this property or "set" this property
      public Face Face { get; set; }//another property 

        public override string ToString()
        {
            return string.Format("{0} of {1}", Face, Suit);
        }

    }
    public enum Suit
    {
        Clubs, 
        Diamonds, 
        Hearts, 
        Spades
    }

    public enum Face
    {
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    }
}
