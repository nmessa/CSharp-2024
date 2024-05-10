//Lab Exercise 5.16.2024 Problem 2
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
            //Add code here

        }

        static int factorial(int n)
        {
            if (n == 0 || n == 1)
                return 1;
            else
                return n * factorial(n - 1);
        }
    }
}

//Sample Output
//Enter the value for X: 2
//Enter the number of terms: 5
//The sum of this series -0.415873015873016
