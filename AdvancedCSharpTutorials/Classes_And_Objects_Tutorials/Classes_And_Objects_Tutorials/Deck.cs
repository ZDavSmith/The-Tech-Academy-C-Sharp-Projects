using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Deck
    {
        public Deck() //Creating Constructor (Always at top of class and uses class name)
        {
            Cards = new List<Card>(); //Cards is reffering to a property of the class we created already (See Below)
            List<string> Suits = new List<string>() { "Clubs", "Hearts", "Diamonds", "Spades" };
            List<string> Faces = new List<string>() { "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace" };
            foreach (string face in Faces)
            {
                foreach (string suit in Suits)
                {
                    Card card = new Card();
                    card.Suit = suit;
                    card.Face = face;
                    Cards.Add(card);
                }
            }




        }
        public List<Card> Cards { get; set; } //Property
        public void Shuffle(int times = 1) //method - public, accesible anywhere, static: dont want to create obj program before calling, Deck = type of data, Shuffle = name of function, (Deck deck) parameter of type Deck, variable name deck
        {

            for (int i = 0; i < times; i++)
            {

                List<Card> TempList = new List<Card>();
                Random random = new Random(); //Random is a class from the framework we can call

                while (Cards.Count > 0)
                {
                    int randomIndex = random.Next(0,Cards.Count); //min value of 0 and max value of 52
                    TempList.Add(Cards[randomIndex]);
                    this.Cards.RemoveAt(randomIndex); // deletes it from the temporary List
                }
                Cards = TempList;
            }

        }
    }
}
