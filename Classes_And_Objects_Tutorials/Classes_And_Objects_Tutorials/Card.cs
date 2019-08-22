using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Card //public lets it be accessable
    {
        //public Card() //Creating a Constructor
        //{
        //    //Suit = "Spades",
        //    //Face = "Two";
        //}
       public string Suit { get; set; } //card class has a property of datatype string, called Suit. You can either "get" this property or "set" this property
       public string Face { get; set; }//another property 
    }
}
