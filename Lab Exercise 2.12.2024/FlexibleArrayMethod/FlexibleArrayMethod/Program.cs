//Lab Exercise 2.12.2024 Problem 3
//Author: 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlexibleArrayMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare and initialize 3 arrays of integers
            int[] one = new int[] { 4, 6, 8, 9};
            int[] two = new int[] { 24,31,12,27,42};
            int[] three = new int[] { 98,23,45,12,6,38,45,67};

            //Call the ShowArray function to display each array and
            //their sum
            showArray(one);
            showArray(two);
            showArray(three);
        }

        static void showArray(int[] arr)
        {
            //Add code here

        }
    }
}

//Sample Output
//4 6 8 9
//Sum of array = 27
//24 31 12 27 42
//Sum of array = 136
//98 23 45 12 6 38 45 67
//Sum of array = 334