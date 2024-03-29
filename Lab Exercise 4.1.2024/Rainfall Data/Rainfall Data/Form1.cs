//Lab Exercise 4.1.2024 Problem 2
//Author: 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Rainfall_Data
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            //Declare variables including a 12 element array of strings to hold 
            //the names of months and a 12 element integer array to hold monthly 
            //rainfall totals
            //This is an example of parallel arrays
            string [] months = new string[] {"January", "February", "March", "April",
                "May", "June", "July", "August", "September", "October", "November",
                "December"};
            int[] data = new int[12];
            string month, maxMonth, minMonth, message;
            int inches, total=0, max, min, index;
            double average;

            //Create a random number generator
            Random r = new Random();

            //Generate data and store in arrays as well as ListBox
            //Add code here


            //Find total rainfall
            //Add code here



            //Find the average rainfall
            //Add code here


            //Find the max rainfall
            //Add code here



            //Find the min rainfall
            //Add code here


            //Put values in labels
            //Add code here

        }
    }
}
