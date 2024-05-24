//Lab Exercise 5.30.2024
//Photo Album
//Author: 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Photo_Album
{
    public partial class Form1 : Form
    {
        //Global variables
        //Create array of image titles
        string[] arrayWords = new string[]  {"Anemone", "Gray Angel", "Sponges", 
            "Scorpionfish", "Starfish"};

        //Create an array of image filenames
        string[] myImages = new string[]  {"anemone.jpg", "grayangel.jpg", "sponges.jpg", 
            "scorpionfish.jpg", "starfish.jpg"};

        int count = -1;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnArrow_Click(object sender, EventArgs e)
        {
            //Advance to next image with rollover
            //Add code here


            //Place image name in lblName
            //Add code here


            //Place image in picPhoto
            //Add code here

        }
    }
}
