//Lab Exercise 2.13.2024 Problem 4
//Author: 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChatAWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare an array of area codes as strings
            //Add code here


            //Declare an array of rates as doubles
            //Add code here


            //Declare variables
            string strBill, areaCode, strRate;
            int minutes, index;
            double bill;

            //Get area  code from user
            //Add code here


            //Find location of area code in the array codes
            //Add code here


            if (index != -1) //Area code found
            {
                //Get minutes talked as an integer
                //Add code here


                //Calculate bill
                //Add code here


                //Convert the bill and rate to currency strings
                //Add code here

                //Output bill
                //Add code here

            }
            else //Area code not found
            {
                //Add code here

            }   
        }
    }
}

//Sample Output
//Enter area code: 414
//Enter the number of minutes talked: 23
//Minutes billed:        23
//Rate:               $0.10
//Total Bill:         $2.30