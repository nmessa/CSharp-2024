//Lab Exercise 5.31.2024 Problem 1
//Author: 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare variables
            Random r = new Random();
            int temp;
            int cows= 0;
            int bulls = 0;
            int count;
            int numGuesses = 0;
            string number = "";
            string guess;

            //Build the secret number
            //Add code here

            //For testing purposes
            //Console.WriteLine(number);

            //Keep guessing until you get 4 cows
            while (cows < 4)
            {
                //get user guess
                //Add code here

                //Count the matches
                //Add code here


                //Find how many numbers in the guess are in the number
                //Add code here


                //Count the cows
                //Add code here


                //Calculate the number of bulls
                //Add code here


                //Output the hint
                //Add code here

            }
            Console.WriteLine("You guessed the number in " + numGuesses + " guesses");
        }
    }
}
