//Lab Exercise 5.22.2024 Problem 4
//Author: 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create 3 test arrays
            int[] arr1 = new int[4] {1, 2, 9, 3};
            int[] arr2 = new int[6] { 1, 2, 3, 4, 5, 6};
            int[] arr3 = new int[4] { 1, 2, 2, 3};

            Console.WriteLine(functionFour(arr1, 3));
            Console.WriteLine(functionFour(arr2, 2));
            Console.WriteLine(functionFour(arr3, 9));
        }

        static bool functionFour(int[] arr, int n)
        {
            //Add code here

        }
    }
}

//Output
//True
//True
//False