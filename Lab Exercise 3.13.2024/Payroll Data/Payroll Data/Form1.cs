//Lab Exercise 3.11.2024
//Author: 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Payroll_Data
{
    public partial class Form1 : Form
    {
        int count;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClearReport_Click(object sender, EventArgs e)
        {
            //Add code here

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Add code here

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Declare variables
            string name, message;
            int hours;
            double fed, med, ss, state, rate, pay, takeHome;
            double fedTax, stateTax, ssTax, medTax;

            //Get data from comboBoxes and textBoxed, convert to double and divide
            //percentages by 100
            //Add code here


            //calculate pay, fedTax, stateTax, ssTax, medTax, and takeHome
            //Add code here


            //Generate report and put in lstOutput
            //Add code here


            //add one to count
            //Add code here


            //if all employees processed, disable add employee button
            //Add code here


        }
    }
}
