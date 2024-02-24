//Lab Exercise 3.5.2024 Problem 2
//Author: nmessa

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Workshop_Registration
{
    public partial class Form1 : Form
    {
        //Declare global variable
        int total;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Declare variables
            int days=0, regFee=0, lodging=0;

            //get workshop registration fee and days
            //Add code here

            //calculate lodging cost
            //Add code here

            //Calculate total cost for workshop and add to total
            //Add code here

            //Add total amount to lstCosts as currency
            //Add code here

        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            //put total in lblCost as currency
            //Add code here

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //Add code here

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Add code here

        }
    }
}
