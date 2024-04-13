//Lab Exercise 4.15.2024 Problem 3
//Author: 
//Pass an array to an function and the function returns an array
//of the square root of each element in the original array

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Array_Square_Root
{
    class Program
    {
        const int SIZE = 10;

        static void Main(string[] args)
        {
            //Declare variables
            Random r = new Random();
            int[] numbers = new int[SIZE];
            double[] numbers2;

            //Fill the array with random integers from 1 to 10000
            for (int i = 0; i < SIZE; i++)
                numbers[i] = r.Next(1, 10000);

            //Pass the array to a function that takes the square root of each element
            numbers2 = on_all(numbers);
            for (int i = 0; i < SIZE; i++)
                Console.WriteLine(numbers[i] + "  " + numbers2[i].ToString("f2"));
        }

        private static double[] on_all(int[] ary)
        {
            //Add code here

        }
    }
}

//Sample Output
//2590  50.89
//2320  48.17
//7622  87.30
//7783  88.22
//4248  65.18
//3298  57.43
//3585  59.87
//1572  39.65
//930  30.50
//5560  74.57
