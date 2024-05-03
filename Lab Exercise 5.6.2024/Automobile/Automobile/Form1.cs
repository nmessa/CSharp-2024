//Lab Exercise 5.6.2024
//Author: 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Automobile
{
    public partial class Form1 : Form
    {
        //Create a global Automobile object
        Automobile myCar;

        //Create a global Color object
        Color color;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnBuild_Click(object sender, EventArgs e)
        {
            //Declare variables
            string make, temp;
            int speed, heading, hp;
            string message = "";

            //Get car info
            //Add code here


            //Update Automobile object
            //Add code here

            //Create Automobile information object
            //Add code here

            //Display Autombile object information
            //Add code here

            //Reset all values
            //Add code here
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Construct Automobile object
            myCar = new Automobile();
        }

        private void btnPaint_Click(object sender, EventArgs e)
        {
            //Set the color of the car using ColorDialog
            //Add code here
        }

        private void trkSpeed_Scroll(object sender, EventArgs e)
        {
            //Set the speed
            //Add code here
        }

        private void trkHeading_Scroll(object sender, EventArgs e)
        {
            //Set the heading
            //Add code here
        }

        private void trkHP_Scroll(object sender, EventArgs e)
        {
            //Set the horsepower
            //Add code here
        }
    }
}
