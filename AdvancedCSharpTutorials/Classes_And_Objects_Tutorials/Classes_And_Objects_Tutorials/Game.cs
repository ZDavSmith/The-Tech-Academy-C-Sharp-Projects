using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public abstract class Game  //This class is abstract because an object will never be created from it. There will always be a type of game that inherits from the general type: Game
    {
        private List<Player> _players = new List<Player>(); //instantiating a LIst
        private Dictionary<Player, int> _bets = new Dictionary<Player, int>();

        public List<Player> Players { get { return _players; } set { _players = value; } }
        public string Name { get; set; }
        public Dictionary<Player, int> Bets { get { return _bets; } set { _bets = value; } }

        public abstract void Play(); //abstract method is a method that can only exist inside abstract class and contains NO implementation. All it does is state that any class inheriting this class MUST have this method. //Its saying it will have it with the parameters in its class
        public virtual void ListPlayers() //virtual methods exist within an abstract class: It means that this method get inherited by an inheriting class, but has the ability to override it(They have implementation, but can be overwritten)
        {
            foreach (Player player in Players)
            {
                Console.WriteLine(player);
            }
        }
    }
}
