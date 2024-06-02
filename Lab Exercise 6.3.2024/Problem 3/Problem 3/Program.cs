//Lab Exercise 6.3.2024 Problem 3
//Author: 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 1000; i++)
            {
                if (isHappy(i))
                    Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        static bool isHappy(int num)
        {
            //Create an empty list to hold results
            //Add code here


            //Initialize total to 0
            //Add code here


            //Convert number being tested into a string
            //Add code here


            while (true)
            {

                //Calculate total
                //Add code here


                //return True if the total is 1
                //Add code here


                //check to see if total is in sad list
                //if it is, return False since it
                //will start repeating forever
                //if total is not in sad list, add it to
                //the sad list
                //Add code here


                //Convert total to a string
                //Add code here


                //Reset total to 0
                //Add code here


            }  
        }
    }
}
