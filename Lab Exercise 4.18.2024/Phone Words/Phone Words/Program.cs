//Lab Exercise 4.18.2024 Problem 3
//Author: 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Phone_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare variables
            string number, numString, numString2;

            //Get phone number from user
            Console.Write("Enter a phone number (xxx-xxxx): ");
            number = Console.ReadLine();

            //Store first 3 digits in numString
            numString = number.Substring(0, 3);

            //Store last 4 digits in numString2
            numString2 = number.Substring(4);

            //Find 3 letter word matches
            Console.WriteLine("Words for " + numString);
            findMatches(numString);
            Console.WriteLine();

            //Find 4 letter word matches
            Console.WriteLine("Words for " + numString2);
            findMatches2(numString2);
        }

        //Finds matches for 3-letter words
        private static void findMatches(string ns)
        {
            //Open words.txt for read access by creating FileStream and StreamReader objects
            FileStream fs = new FileStream("words.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(fs);


            string word = "";
            string numWord = "";

            //Read all of the words in words.txt
            while (! reader.EndOfStream)
            {
                //Read a line
                //Add code here

                //If length of word is 3 then convert to numWord
                //If numWord equals ns then write the word to console
                //Add code here
                

            }
            //Close StreamReader and FileStream
            //Add code here

        }

        //Find matches for 4 letter words
        private static void findMatches2(string ns)
        {
            FileStream fs = new FileStream("words.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(fs);
            string word = "";
            string numWord = "";

            //Read all of the words in words.txt
            while (!reader.EndOfStream)
            {
                //Read a line
                //Add code here


                //If length of word is 4 then convert to numWord
                //If numWord equals ns then write the word to console
                //Add code here

            }

            //Close StreamReader and FileStream
            //Add code here

        }


        private static string convertWord(string w)
        {
            string temp = "";
            for (int i = 0; i <= 2; i++)
                temp += translate(w[i]);
            return temp;

        }

        private static string convertWord2(string w)
        {
            //Similiar to convertWord


        }

        private static string translate(char ch)
        {
            //Use code from problem 1

        }
    }
}

//Sample Output
//Enter a phone number (xxx-xxxx): 772-3456
//Words for 772
//SPA

//Words for 3456
//FILM
//FILO
