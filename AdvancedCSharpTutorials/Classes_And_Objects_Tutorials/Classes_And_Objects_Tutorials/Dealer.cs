using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TwentyOne
{
     public class Dealer
    {
        public string Name { get; set; }
        public Deck Deck { get; set; }
        public int Balance { get; set; }

        public void Deal(List<Card> Hand)
        {
            Hand.Add(Deck.Cards.First()); //First is method that ouputs the first item in a list
            Console.WriteLine(Deck.Cards.First().ToString() + "\n");
            Deck.Cards.RemoveAt(0); //Remove at is a method that you pass in an index of where you want to remove. In this case, we dont want the card in the players hand to be available to anyone else
        }
    }
}
