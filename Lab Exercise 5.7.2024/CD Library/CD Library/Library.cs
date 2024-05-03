//Library Class
//Author: 
//Date 5.7.2024

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace CD_Library
{
    class Library
    {
        //Class properties
        private int myNumCDs;
        private CD[] myCDs; //Empty array that can hold CD objects

        //Constructor
        public Library()
        {
            int index;

            //Open a file to read in songs information
            GlobalVariables.fs = new FileStream("songs.txt", FileMode.Open, FileAccess.Read);
            GlobalVariables.textFile = new StreamReader(GlobalVariables.fs);

            //Read in the number of CDs in the library
            //Add code here

            //Resize the array to hold the number of CDs
            //Add code here

            //Fill array with CD objects
            //Add code here

            //Close the file
            GlobalVariables.textFile.Close();
            GlobalVariables.fs.Close();
        }

        //Display the Library
        public void showLibrary()
        {
            int index;
            Console.WriteLine("The CD Library Contains: ");

            //Display each CD in the Library
            //Add code here

        }
    }
}
