//Lab Exercise 5.9.2024 Problem 2
//Author: 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_2
{
    class Program
    {
        static void Main(string[] args)
        {  
            Console.WriteLine(checkTitle("A Mind Boggling Achievement"));
            Console.WriteLine(checkTitle("A Simple C++ Program!"));
            Console.WriteLine(checkTitle("Water is transparent"));
        }

        static bool checkTitle(string s)
        {
            //Declare local variables 
            string w;
            string[] words;

            //Split the string into words
            //Add code here


            //Parse the words array
            for (int i = 0; i < words.Length; i++)
            {
                //Store word in w
                //Add code here

                //If first character is not upper case return false
                //Add code here

            }

            return true;
        }
    }
}

//Output
//True
//True
//False
