//Lab Exercise 4.15.2024 Problem 5
//Author: 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Base_Conversion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            //Declare variables
            int number;
            int myBase;
            int remainder;
            string[] translate = new string[] {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9",
                "A", "B", "C", "D", "E", "F"};
            string converted = "";

            //Get number to convert from textbox
            //Add code here


            //Get base to convert to from combo box
            //Add code here


            //Repeat division until number is 0
            while (number > 0)
            {
                //Execute algorithm
                //Add code here

            }

            //Reverse the string and store in converted
            //Add code here


            //Print answer to label
            //Add code here

        }


        private string reverseString(string str)
        {
            string newString  = "";
            //Parse string from end to beginning build a new string
            for (int i = str.Length - 1; i >= 0; i--)
                newString += str[i];
            return newString;
        }
    }
}
