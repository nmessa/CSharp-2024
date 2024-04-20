//Lab Exercise 4.30.2024 Problem 1
//Author: 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_1
{
    class Program
    {
        //Global variables
        static int coach;
        static int firstClass;
        static int regular;
        static int veggie;
        static int choice;
        static char selectClass;
        static char selectMeal;

        static void Main(string[] args)
        {
            
            while (true)
            {
                menu();
                switch (choice)
                {
                    case 1:
                        addPassenger();
                        break;
                    case 2:
                        report();
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;      
                }
            }
        }

        //Function to display menu
        static void menu()
        {
            //Add code here

        }

        //Function to add a passenger
        static void addPassenger()
        {
            //Clear Console
            //Add code here


            //Get desired class from user as an upper case character
            //Add code here


            //Process class selection
            //Need to determine if first class or coach is full
            //or invalid choice
            //Also determine if plane is full
            switch (selectClass)
            {
                case 'F':
                    //Add code here

                case 'C':
                    //Add code here

                default:
                    //Add code here

            }//end of switch

            //Get desired meal from user as an upper case character
            //Add code here


            //Process meal request as regular, vegetarian, of invalid choice
            switch (selectMeal)
            {
                case 'R':
                    //Add code here

                case 'V':
                    //Add code here

                default:
                    //Add code here
 
            }
        }//end of addPassenger

        //Function to generate a report
        static void report()
        {
            //Add code here

        }
    }
}
