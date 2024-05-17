//Lab Exercise 5.23.2024 Problem 3
//Author: 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[10] { 3, 5, 1, 5, 3, 5, 7, 5, 1, 5};
            int[] arr2 = new int[7] { 3, 5, 5, 5, 5, 5, 5};
            int[] arr3 = new int[10] { 3, 5, 2, 5, 4, 5, 7, 5, 8, 5};
            int[] arr4 = new int[6] { 2, 4, 5, 5, 5, 5};
            int[] arr5 = new int[10] { 3, 5, 5, 5, 5, 5, 5, 5, 5, 5};

            Console.WriteLine(functionThree(arr1));
            Console.WriteLine(functionThree(arr2));
            Console.WriteLine(functionThree(arr3));
            Console.WriteLine(functionThree(arr4));
            Console.WriteLine(functionThree(arr5));
        }

        static bool functionThree(int[] arr)
        {
            //Add code here

        }
    }
}

//Output
//True
//False
//True
//False
//False