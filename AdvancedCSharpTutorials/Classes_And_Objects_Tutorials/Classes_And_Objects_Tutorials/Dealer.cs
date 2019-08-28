using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
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
            string card = string.Format(Deck.Cards.First().ToString() + "\n");
            Console.WriteLine(card);
            using (StreamWriter file = new StreamWriter(@"C:\Users\Zachary\logs\log.txt", true)) //true, yes I want to append to the log
            {
                file.WriteLine(card);
            }
            Deck.Cards.RemoveAt(0); //Remove at is a method that you pass in an index of where you want to remove. In this case, we dont want the card in the players hand to be available to anyone else
        }
    }
}
