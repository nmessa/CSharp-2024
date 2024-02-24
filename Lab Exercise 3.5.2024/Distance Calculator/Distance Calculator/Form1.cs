//Lab Exercise 3.5.2024 Problem 4
//Author: 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Distance_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Add code here

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Add code here

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            //Declare variables
            int speed, distance, hours;
            string message;

            //Get input from user
            //Add code here


            //Add heading to list box
            lstOutput.Items.Add("Vehicle Speed: " + speed + " MPH");
            lstOutput.Items.Add("Time Traveled: " + hours + " hours");
            lstOutput.Items.Add("Hours:     Distance Traveled");
            lstOutput.Items.Add("____________________________");

            //Calculate ddistance traveled each hour and add result to list box
            //Add code here

        }
    }
}
