//Lab Exercise 3.26.2024
//Author: 
//frmOptions.cs

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Conference_Application
{
    public partial class frmOptions : Form
    {
        //Constructor
        public frmOptions()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //Local variables
            //Add code here


            if (ckbReg.Checked)     //registered for conference
            {
                //Add code here

                
                //Add cost and select name of chosen workshop
                //Add code here


                //get workshop information back to main form
                //Add code here

            }
            //get total cost infornation back to main form
            //Add code here


            //Close current form
            //Add code here

        }
    }
}
