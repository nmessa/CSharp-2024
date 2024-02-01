//Demo to show how to find a substring within a sting abd a character in a string
//Author: nmessa
//Date: 2.4.2022

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Finding
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare variables
            string testString = "abcde";
            string toFind;
            char ch;
            int index;

            //Enter a letter as a string
            Console.Write("Enter a letter: ");
            toFind = Console.ReadLine();

            //Test to see if a string is found in another string
            if (testString.Contains(toFind))
                Console.WriteLine("Found the letter");
            else
                Console.WriteLine("Letter not found");

            //Convert the string letter to a char
            ch = toFind[0];

            //Find the location of the char inside the string
            index = testString.IndexOf(ch);
            if (index != -1)
                Console.WriteLine("Found {0} at location {1}", ch, index);
            else
                Console.WriteLine("{0} not found", ch);
        }
    }
}

//Sample output
//Enter a letter: c
//Found the letter
//Found c at location 2
