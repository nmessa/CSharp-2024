﻿//Lab Exercise 5.8.2024 Problem 3
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
            //Create 3 arrays
            int[] a1 = {3, 4, 9};
	        int[] a2 = {0, 0, 0};
	        int[] a3 = {1, 2, 3};

            //Pass arrays to function
            int[] a4 = evenOddTransform(a1, 3);
            int[] a5 = evenOddTransform(a2, 10);
            int[] a6 = evenOddTransform(a3, 1);

            //Print the arrays
            printArray(a4);
	        printArray(a5);
	        printArray(a6);
        }

        static int [] evenOddTransform(int[] a, int n)
        {
            //Create a copy of passed array
            //Add code here

            //Perform transform n times
            for (int count = 1; count <= n; count++)
            { 
                //Transform each element of array
                //Add code here

            }

            //Return the array
            return arr;
        }

        static void printArray(int[] a)
        {
	        for (int i = 0; i < a.Length; i++)
		        Console.Write(a[i] + " ");
            Console.WriteLine();
        }
    }
}

//Output
//9 -2 15
//-20 -20 -20
//3 0 5