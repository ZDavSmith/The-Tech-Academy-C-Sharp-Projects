using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            //==============================
            //CREATING CLASSES AND OBJECTS
            //==============================

            Deck deck = new Deck();
            deck = Shuffle(deck); //Shuffling the cards

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
        }

        //===============================
        //SHUFFLE METHOD FOR THE CARDS
        //===============================


        public static Deck Shuffle(Deck deck) //method - public, accesible anywhere, static: dont want to create obj program before calling, Deck = type of data, Shuffle = name of function, (Deck deck) parameter of type Deck, variable name deck
        {
            List<Card> TempList = new List<Card>();
            Random random = new Random(); //Random is a class from the framework we can call

            while (deck.Cards.Count > 0)
            {
                int randomIndex = random.Next(0, deck.Cards.Count); //min value of 0 and max value of 52
                TempList.Add(deck.Cards[randomIndex]);
                deck.Cards.RemoveAt(randomIndex); // deletes it from the temporary List
            }
            deck.Cards = TempList;
            return deck;
        }
    }
}
