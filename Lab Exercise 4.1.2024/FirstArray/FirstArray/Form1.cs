﻿//Lab Exercise 4.1.2024 Problem 1
//Author: 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FirstArray
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            //Declare variables including a 50 element array of integers
            int [] numbers = new int[50];
            int number, index;
            int max, min;

            //Create a random number generator
            Random r = new Random();

            //Fill array with random numbers (0 - 1000) and add values to ListBox
            //Add code here


            //Find the largest value in the array
            //Add code here


            //Find the smallest value in the array
            //Add code here


            //Put the max and min value in labels
            //Note: By concatenating the nubmer to a string, we do not need to use
            //the toString() function
            //Add code here

        }
    }
}
