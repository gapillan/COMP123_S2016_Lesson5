using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_S2016_Lesson5
{
    /**
     * This class is the "driver" class for our Program 
     * 
     * @class Program 
     */

    public class Program
    {
        /**
         * The main method of our driver class Program 
         * 
         * @method Main 
         * @param {string[]} args
         */
        public static void Main(string[] args)
        {
            // List that represents deck of cards
            List<Card> Deck = new List<Card>();

            CreateDeck(Deck);
            DisplayDeck(Deck);


        } // end Main

        // PUBLIC STATIC METHODS ++++++++++++++++++++++++++++++++++++++++++++++++++++

        /**
         * <summary>
         * This method loads a list of cards with Card objects
         * </summary>
         * 
         * @method CreateDeck
         * @param {List<Card>} deck
         * @returns {void}
         */
        public static void CreateDeck(List<Card> deck)
        {
            string suit = "";

            for (int suitIndex = 0; suitIndex < 4; suitIndex++)
            {
                switch (suitIndex)
                {
                    case 0:
                        suit = "hearts";
                        break;
                    case 1:
                        suit = "clubs";
                        break;
                    case 2:
                        suit = "diamonds";
                        break;
                    case 3:
                        suit = "spades";
                        break;

                } // end suit switch

                for (int face = 1; face < 14; face++)
                {
                    deck.Add(new Card(face, suit));
                } // end for - face 
            }
        }

        /**
         * <summary>
         * This method displays a list of Card objects to the console 
         * </summary>
         * 
         * @method DisplayDeck 
         * @param (List<card>) deck 
         * @returns {void}
         */
        public static void DisplayDeck(List<Card> deck) 
        {
            Console.WriteLine("++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("+            Current Deck          +");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++");
            foreach (Card card in deck) 
            {
                Console.WriteLine("{0} of {1}", card.Face, card.Suit);
            }
            Console.WriteLine("++++++++++++++++++++++++++++++++++++");
            Console.WriteLine();
        }

        public static void ShuffleDeck(List<Card> deck) 
        {
            // creates a psuedo-random number sequence and stores it in random 
            Random random = new Random(); 
            // recod the number of cards in the deck list 
            int cardCount = deck.Count;

            // iterate through the list of cards
            for (int currentCard = 0; currentCard < cardCount; currentCard++) 
            {
                Card tempCard = deck[currentCard]; // copy curretnt card to temp location 
                int randomCard = random.Next(0, cardCount); // get a random index
            }
        }
    } // end Program 
} // end namespace 
