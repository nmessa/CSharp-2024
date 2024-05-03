//Lab Exerecise 5.9.2024 Problem 1
//Author: 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create 3 arrays
            int[] a1 = {4, 5, 2, 1, 4, 9, 7, 2};
            int[] a2 = {1, 2, 1, 1, 3, 2, 5, 4, 4};
            int[] a3 = {1, 2, 3, 4, 5, 6};

            //Pass arrays to function and store return in list
            List<int> a4 = miniPeaks(a1);
            List<int> a5 = miniPeaks(a2);
            List<int> a6 = miniPeaks(a3);

            //Print the lists
            printList(a4);
            printList(a5);
            printList(a6);
        }

        static List<int> miniPeaks(int[] a)
        {
            //Create a list to hold integers
            //Add code here

            //Search for peaks
            //Add code here


            //Return the peaks list
            return peaks;
        }

        static void printList(List<int> lst)
        {
            Console.Write("[");
            for (int i = 0; i < lst.Count; i++)
                Console.Write(lst[i] + " ");
            Console.WriteLine("]");
        }
    }
}

//Output
//[5 9 ]
//[2 3 5 ]
//[]