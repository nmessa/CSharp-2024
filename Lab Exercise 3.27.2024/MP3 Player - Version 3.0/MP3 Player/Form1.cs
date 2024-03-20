//Lab Exercise 3.27.2024
//Author: 
//Version 3.0

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MP3_Player
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            play();
        }

        private void play()
        {
            //Create a PlayList object
            //Add code here


            //Add each item in the playList ListBox to the PlayList object
            //Add code here


            //Start playing the playlist
            //Add code here

        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            //Add code here

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            //Add code here

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Add code here

        }

        private void playList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Add code here

        }

        private void savePlaylistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Add code here


        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loadPlaylistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Add code here

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Add code here

        }
    }
}
