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
            //deck = Shuffle(deck); //Shuffling the cards
            int timesShuffled = 0;
            deck = Shuffle(deck: deck, out timesShuffled, times: 3); //Showing Named Paramteters to make the code more readable
    

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.WriteLine("Times shuffled: {0}", timesShuffled); //String format, in brackets a 0 and then the variable ou want to be assigned to it
            Console.ReadLine();
        }

        //===============================
        //SHUFFLE METHOD FOR THE CARDS
        //===============================

        // int times = 1 is an optional perameter because its assigned a 1
        public static Deck Shuffle(Deck deck, out int timesShuffled, int times = 1) //method - public, accesible anywhere, static: dont want to create obj program before calling, Deck = type of data, Shuffle = name of function, (Deck deck) parameter of type Deck, variable name deck
        {
            timesShuffled = 0;
            for (int i = 0; i < times; i++)
            {
                timesShuffled++;
                List<Card> TempList = new List<Card>();
                Random random = new Random(); //Random is a class from the framework we can call

                while (deck.Cards.Count > 0)
                {
                    int randomIndex = random.Next(0, deck.Cards.Count); //min value of 0 and max value of 52
                    TempList.Add(deck.Cards[randomIndex]);
                    deck.Cards.RemoveAt(randomIndex); // deletes it from the temporary List
                }
                deck.Cards = TempList;
            }
                return deck;
            
        }

        //==========================================================
        //METHOD FOR SHUFFLING AS MANY TIMES AS THE DEALER WANTS (Commented out because it was inserted into the main method)
        //==========================================================
        //public static Deck Shuffle(Deck deck, int times)
        //{
        //    for (int i = 0; i < times; i++)
        //    {
        //        deck = Shuffle(deck);
        //    }
        //    return deck;
        //}



    }
}
