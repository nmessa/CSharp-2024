//Lab Exercise 4.4.2024 Problem 3
//Author: 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ski_Wax
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWax_Click(object sender, EventArgs e)
        {
            //Declare variables
            int temperature;
            string conditions;
            string message;
            string variety = null;
            string group = null;

            //Get temperature from textbox and store as integer
            //Add code here


            //Check for invalid temperature (<-50 or > 100) if so reset and exit function
            //Add code here


            //Get selected item from combobox and store in conditions
            //Add code here


            //Determine variety
            switch (conditions)
            {
                //Add code here

            }

            //Determine group
            //Add code here


            //Output the result
            //Add code here

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //Add code here

        }
    }
}
