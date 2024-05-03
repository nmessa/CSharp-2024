//Lab Exerecise 5.13.2022 List Demo
//Author: nmessa

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

            //Create List
            List<int> myList = new List<int>();

            //Add 5 elements to list
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter an integer: ");
                myList.Add(Convert.ToInt32(Console.ReadLine()));
            }

            //Print the lists
            printList(myList);

            //Fill List from array
            myList.Clear();
            for (int i = 0; i < a1.Length; i++)
            {
                myList.Add(a1[i]);
            }
            printList(myList);
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

//Sample Output
//Enter an integer: 34
//Enter an integer: 65
//Enter an integer: 23
//Enter an integer: 71
//Enter an integer: 12
//[34 65 23 71 12 ]
//[4 5 2 1 4 9 7 2 ]