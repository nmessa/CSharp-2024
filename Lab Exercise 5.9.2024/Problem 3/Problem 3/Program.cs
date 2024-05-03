//Lab Exercise 5.9.2024 Problem 3
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
            Console.WriteLine(isBoiling("212F"));
            Console.WriteLine(isBoiling("100C"));
            Console.WriteLine(isBoiling("0F"));
        }

        static bool isBoiling(string s)
        {
            //Create variable to hold temperature
            int x;
            //Create variable to hold scale (F or C)
            char scale;

            //Extract the temperature scale from the string
            //Add code here

            //Extract the temperature from the string
            //Add code here

            //Convert the string temperature to an integer
            //Add code here

            //Determine if boiling for Fahrenheit scale
	        //Add code here


            //Determine if boiling for Celsius scale
            //Add code here

            //Handle situation for invalid temperature string
            //Add code here

        }
    }
}

//Output
//True
//True
//False