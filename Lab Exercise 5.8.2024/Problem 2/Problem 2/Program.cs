//Lab Exercise 5.8.2024 Problem 2
//Author: 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(doubleSwap("aabbccc", 'a', 'b'));
            Console.WriteLine(doubleSwap("random w#rds writt&n h&r&", '#', '&'));
            Console.WriteLine(doubleSwap("128 895 556 788 999", '8', '9'));
        }

        static string doubleSwap(string s, char c1, char c2)
        {
            string newString = "";

            //Parse the string
	        for (int i = 0; i < s.Length; i++)
	        {
                //Replace c1 with c2
		        //Add code here

                //Replace c2 with c1
		        //Add code here

                //Use the original character
                //Add code here

	        }
	        return newString;
        }
    }
}

//Output
//bbaaccc
//random w&rds writt#n h#r#
//129 985 556 799 888