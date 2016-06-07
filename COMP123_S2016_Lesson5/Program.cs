﻿using System;
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

          Deck deck = new Deck(); // create a deck of cards 

            deck.Display(); // display the initial state of the deck 

            deck.Shuffle(); // shuffle the deck 
            deck.Display(); // display the deck after shuffling 
        }
    } // end Program 
} // end namespace 
