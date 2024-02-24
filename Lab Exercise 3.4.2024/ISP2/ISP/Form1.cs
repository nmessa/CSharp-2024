//Lab Exercise 3.4.2024 Problem 4
//Author: 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ISP
{
    public partial class Form1 : Form
    {
        //Global variable
        const double dblDiscount = 0.2;

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

        private void btnCalc_Click(object sender, EventArgs e)
        {
            //Declare variables
            int hours;
            double totalA, totalB, totalC, discount;

            //Find discount
            //Add code here


            //get input and store in hours
            //Add code here


            //Calculate total for Plan A
            //Add code here


            //Calculate total for Plan B
            //Add code here


            //Calculate total for Plan C
            //Add code here


            //determine bill and plan savings for plan A
            if (radA.Checked)
            {
                lblAmount.Text = totalA.ToString("c");
                if (chkSavings.Checked)
                {
                    lblSavingsOne.Text = "Plan B saves you " + (totalA - totalB).ToString("c");
                    lblSavingsTwo.Text = "Plan C saves you " + (totalA - totalC).ToString("c");
                }      
            }

            //determine bill and plan savings for plan B
            //Add code here


            //determine bill and plan savings for plan C
            //Add code here
                
        }
    }
}
