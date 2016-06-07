using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_S2016_Lesson5
{
    /**
     * <summary>
     * This class extends the List<Card> generic type
     * </summary> 
     * 
     * @class Deck 
     */
    public class Deck : List<Card>
    {
        //CONSTRUCTORS 
        /**
         * <summary>
         * this is the default constructor for the deck class 
         * </summary>
         * 
         * @constructor Deck 
         */
        public Deck()
        {
       
        
        }
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
        private void _create()
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
                    this.Add(new Card(face, suit));
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
        public void Display() 
        {
            Console.WriteLine("++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("+            Current Deck          +");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++");
            foreach (Card card in this) 
            {
                Console.WriteLine("{0} of {1}", card.Face, card.Suit);
            }
            Console.WriteLine("++++++++++++++++++++++++++++++++++++");
            Console.WriteLine();
        }

        public void Shuffle() 
        {
            // creates a psuedo-random number sequence and stores it in random 
            Random random = new Random(); 
            // recod the number of cards in the deck list 
            int cardCount = this.Count;

            Console.WriteLine("Card Count: {0}", cardCount); // displays the total amount of the deck

            // iterate through the list of cards || note: this is also known as an SWAPPING DATA ALGORITHM 
            for (int currentCard = 0; currentCard < cardCount; currentCard++) 
            {
                Card tempCard = this[currentCard]; // copy curretnt card to temp location 
                int randomCard = random.Next(0, cardCount); // get a random index
                this[currentCard] = this[randomCard]; // swap values from randomCard to currentCard
                this[randomCard] = tempCard; // copy current card to the random card
            }
    }
}
