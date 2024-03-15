//Lab Exercise 3.21.2024 Problem 2
//Author: 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Hospital
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Add code here

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            //Declare variables
            int days, stayCharges=0, misc=0, total=0;
            int medication, surgical, lab, rehab;

            //get days from txtStay Textbox
            //Add code here


            //get medication from txtMed Textbox
            //Add code here


            //get surgical from txtSurgical Textbox
            //Add code here


            //get lab from txtLab Textbox
            lab = Convert.ToInt32(txtLab.Text);

            //get rehab from txtRehab Textbox
            //Add code here


            //Call calcStayCharges with days as a parameter and stayCharges as a ref parameter 
            //Add code here


            //Call calcMiscCharges with medication, surgical, lab, and rehab as parameters 
            //and misc as a ref parameter
            //Add code here


            //Call calcTotalCharges with stayCharges and misc as parameters 
            //and total as a ref parameter
            //Add code here


            //Output total to lblTotal
            //Add code here

        }

        //Since stayCharges is a ref parameter, the value of stayCharges is automatically available 
        //to the calling function
        private void calcStayCharges(int d, ref int stayCharges)
        {
            //Add code here

        }

        //Since misc is a ref parameter, the value of misc is automatically available to the
        //calling function
        private void calcMiscCharges(int medication, int surgical, int lab, int rehab, ref int misc)
        {
            //Add code here

        }

        //Since total is a ref parameter, the value of total is automatically available to the
        //calling function
        private void calcTotalCharges(int stayCharges, int misc, ref int total)
        {
            //Add code here

        }
    }
}
