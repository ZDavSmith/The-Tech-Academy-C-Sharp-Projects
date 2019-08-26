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
            deck.Shuffle(times: 3);

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
        }


    }
}
