//Lab Exercise 3.7.2024 Problem 2
//Author: 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Hotel_Occupanncy
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Add code here

        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            //Declare variables
            int totalRooms=0, floorRooms;
            double rate, floorRate;
            string message;

            //Create an array of TextBoxes
            TextBox[] floors = new TextBox[] { txt1, txt2, txt3, txt4, txt5, txt6, txt7, txt8 };

            //Process each floor
            for (int floor = 1; floor <= 8; floor++)
            {
                //Get number of occupied rooms
                //Add code here


                //Calculate occupancy rate for the floor
                //Add code here


                //Build the message
                //Add code here


                //Add message to list box
                //Add code here


                //Add rooms occupied on floor to total rooms occupied
                //Add code here


                //Reset floorRooms to 0
                //Add code here

            }
            
            //Calculate the hotel occupancy rate
            //Add code here


            //Output total rooms and occupancy rate
            //Add code here

        }
    }
}
