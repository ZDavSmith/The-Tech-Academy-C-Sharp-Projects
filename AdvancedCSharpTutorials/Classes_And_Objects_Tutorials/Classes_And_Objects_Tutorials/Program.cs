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



            //==============================
            //POLYMORPHISM DEMO
            //==============================
            //List<Game> games = new List<Game>();
            //Game game = new TwentyOneGame(); //Polymorphism - one object (TwentyOneGame) can morph into that object
            //games.Add(game);
            //================================================================


            //TwentyOneGame game = new TwentyOneGame();
            //game.Players = new List<string>() { "Jesse", "Daneiel", "Bill" };
            //game.ListPlayers();
            //Console.ReadLine();

            //Creating the Deck and Shuffling it
            //Game game = new TwentyOneGame();
            //game.Players = new List<Player>(); //instantiating the List Player
            //Player player = new Player();
            //player.Name = "Zach";
            //game += player;
            //game -= player;


            Deck deck = new Deck();

            //LAMDA FUNCTIONS

            // int count = deck.Cards.Count(x => x.Face == Face.Ace); //x is all the elements in the deck we're counting. -- Where xFace == Face.Ace ( => means "Map this expression to each item")

            // List<Card> newList = deck.Cards.Where(x => x.Face == Face.King).ToList(); //.Where is similar to an SQL Where. It creates a new list

            List<int> numberList = new List<int>() { 1, 2, 3, 555, 342, 23 };
            int sum = numberList.Sum(x => x + 5);
            int sum2 = numberList.Max();
            int sum3 = numberList.Min();
            Console.WriteLine(sum + sum2 + sum3);




            //deck.Shuffle(times: 3);

            //foreach (Card card in deck.Cards)
            //{
            //    Console.WriteLine(card.Face + " of " + card.Suit);
            //}
            //Console.WriteLine(deck.Cards.Count);
            //Console.ReadLine();
        }


    }
}
