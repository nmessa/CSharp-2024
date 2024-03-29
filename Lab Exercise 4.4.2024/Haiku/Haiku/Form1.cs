//Lab Exercise 4.4.2024 Problem 1
//Author: 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Haiku
{
    public partial class Form1 : Form
    {
        //Declare string arrays to hold haiku phrases
        //Add code here


        //Create a random number generator
        //Add code here


        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            //Create local variables
            //Add code here


            //Generate random numbers and build haiku
            //Add code here


            //Place Haiku into label
            //Add code here

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //Load arrays with phrases
            five[0] = "Trying to hold on";
            five[1] = "Nothing stays the same";
            five[2] = "Garden Is dying";
            five[3] = "Garden Is alive";
            five[4] = "Fire ants are stalking";
            five[5] = "My okra looks grand";
            five[6] = "Please open the door";
            five[7] = "Heavy eyelids droop";
            five[8] = "Soft, light cooling breeze";
            five[9] = "for this gift, thank you";

            seven[0] = "So large and incredible!";
            seven[1] = "They found food that's now walking";
            seven[2] = "Easy, fast and light, so light";
            seven[3] = "A garden seeks it's own way";
            seven[4] = "Cool nighttime air drifts in";
        }

    }
}
