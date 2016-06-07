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
            // create a new variable class called MyList

            //MyList myList = new MyList();

            //myList.Add(1);
            //myList.Add(5);
            //myList.Clear();
            //myList.Print();
            Console.WriteLine();

            // List that represent the deck of cards || creating a string type list 

            List<string> names = new List<string>();

            names.Add("Tom");
            names.Add("Mary");
            names.Add("Jerry");


            int count = 0;
            Console.WriteLine();
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++");
            foreach (string name in names)
            {
                Console.WriteLine("Name#" + count + " is " + name);
                count++;
            }
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++");

            // creating a Deck list 

            List<Card> Deck = new List<Card>();

            CreateDeck(Deck);
        }

        public static void CreateDeck(List<Card> deck) 
        {
            string suit;

            for (int i = 1; i < 4; i++)
			{
			 switch(i) 
             {
                 case 0;
                     suit = "hearts";
                     break;
                     case 1;
                     suit = "clubs";
                     break;
                     suit = "Diamonds";
                     break;
                     suit = "Spades";
                     break;

             }
			}
            for (int index = 1; index < 14; index++) 
            {
                deck.Add(new Card(index, string ));
            }
        }
    }
}
