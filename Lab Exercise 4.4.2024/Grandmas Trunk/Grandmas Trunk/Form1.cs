//Lab Exercise 4.4.2024 Problem 2
//Author: 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Grandmas_Trunk
{
    public partial class Form1 : Form
    {
        //Create global variables
        //Add code here


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Add code here

        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Keep track of the number of items added to the trunk
            //Add code here

   
            if (first)
            {
                //add first item
                //Add code here

            }
            else
            {
                //add subsequent items
                //Add code here

            }

            //Add message to textbox
            //Add code here


            //Finished adding items
            //Add code here

        }

        //This function allows the user to use Enter key to add items
        private void txtAdd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //Keep track of the number of items added to the trunk
                //Add code here


                if (first)
                {
                    //add first item
                    //Add code here

                }
                else
                {
                    //add subsequent items
                    //Add code here

                }

                //Add message to textbox
                //Add code here


                //Finished adding items
                //Add code here

            }
        }
    }
}
