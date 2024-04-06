//Lab Exercise 4.11.2024 Problem 3
//Author: 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Helmets
{
    public partial class Form1 : Form
    {
        //Global array to keep track of helmet status
        //Global array initialized to 0 in all elements
        //Add code here


        public Form1()
        {
            InitializeComponent();
        }

        private void btnSim_Click(object sender, EventArgs e)
        {
            //Declare local variables
            //Add code here


            //Keep looping until you have bought 32 unique helmets
            while (total != 32)
            {
                //Buy a helmet
                //Add code here

                //Find which helmet you bought
                //Add code here

                //Only increment if 0 in element
                //Add code here

                //Find the total of unique helmets you have purchased
                //Add code here
            }

            //Output the amount spend on obtaining 32 unique helmets
            //Add code here


            //Reset array for next simulation
            //Add code here
        }

        //Adds up all of the elements
        //If the sum is 32 that means you have purchased one of each
        private int calcTotal()
        {
            //Declare and initialize variable
            //Add code here

            //Add up the values in the array elements
            //Add code here

            //return the sum of helmets
            //Add code here
        }
    }
}
