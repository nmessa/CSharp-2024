//Lab Exercise 4.15.2024 Problem 4
//Author: 


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Digit_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.Write("Enter a number: ");
            number = Convert.ToInt32(Console.ReadLine());
            
            int[] ary;
            ary = returnArray(number);

            //Print the contantes of the integer array
            for (int i = 0; i <  ary.Length; i++)
                Console.Write(ary[i] + "  ");
            Console.WriteLine();
        }

        //This function returns an integer array of the digits passed to it
        private static int[] returnArray(int num)
        {
            string strNum;
            //Convert num to string
            //Add code here


            //Create an integer array of the appropriate size
            //Add code here


            //Fill the new array with the "digits"
            //Subtract 48 to get ASCII value into numeric value
            //Add code here


            //return the integer array
            //Add code here

        }
    }
}

//Sample Output
//Enter a number: 123456
//1  2  3  4  5  6
