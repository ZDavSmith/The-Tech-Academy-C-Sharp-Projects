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
            deck.Shuffle(times: 3); //Showing Named Paramteters to make the code more readable
    

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

        // int times = 1 is an optional perameter because its assigned a 1
        

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
