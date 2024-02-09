//Lab Exercise 2.12.2024 Problem 1
//Author: 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Desks
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare variables
            int drawers;
            char woodType;
            int cost;

            //Get the number of drawers the desk will have
            drawers = numberOfDrawers();

            //Get the type of wood the desk will have
            woodType = typeOfWood();

            //Call CalcCosts function to the cost of the desk based on number of 
            //drawers and type of wood which are passed as parameters
            cost = calcCosts(drawers, woodType);

            //Call the DisplayDesk function passing type of wood, number of drawers
            //and cost as parameters
            displayDesk(woodType, drawers, cost);
        }

        //This function gets the number of drawers and returns that value as an integer
        static int numberOfDrawers()
        {
            //Add code here

        }

        //This function gets the type of wood and returns that value as a char
        static char typeOfWood()
        {
            //Add code here

        }

        //This function is passed the number of drawers ad type of wood as parameters
        //and returns cost of desk
        static int calcCosts(int numDrawers, char woodType)
        {
            int cost;
            const int DRAWER_COST = 30;

            //Get base cost
            //Add code here


            //Add drawer surcharge
            //Add code here

        }

        //This function displays desk information based on the parameters
        //passed to it (type of wood, number of drawers, and cost)
        static void displayDesk(char woodType, int numDrawers, int cost)
        {
            //Add code here


            

        }
    }
}
//Sample Output
//How many drawers does the desk have? 4
//What type of wood? ('m' = mahogany 'o' = oak 'p' = pine) o
//Wood Type             Oak
//Number of drawers     4
//Final Price           $260.00