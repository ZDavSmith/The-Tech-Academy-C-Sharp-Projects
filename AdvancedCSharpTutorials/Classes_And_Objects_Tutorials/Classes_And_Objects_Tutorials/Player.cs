using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
     public class Player
    {
        public List<Card> Hand { get; set; }
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool isActivelyPlaying { get; set; }

        public static Game operator+ (Game game, Player player) //Overloading operators
        {
            game.Players.Add(player); //takes the game, adds the player to it, and returns the game
            return game;
        }

        public static Game operator-(Game game, Player player)
        {
            game.Players.Remove(player); //game.Players is a list
            return game;
        }
    }
}
