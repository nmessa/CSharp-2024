//Lab Exercise 3.5.2024 Problem 3
//Author: 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SumOfNumbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Add code here

        }

        private void btnNumber_Click(object sender, EventArgs e)
        {
            //Declare variables
            int number, sum, count;
            string message;

            //Get user input
            //Add code here


            //initialize sum to 0
            //Add code here


            //Add upt the numbers
            //Add code here


            //Build message
            //Add code here


            //Send message to a message box
            //Add code here

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtNumber.Text = "";
            txtNumber.Focus();
        }
    }
}
