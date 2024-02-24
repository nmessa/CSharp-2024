using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Listbox_Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNumber.Text = "";
            lstNumbers.Items.Clear();
            txtNumber.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lstNumbers.Items.Add(txtNumber.Text);
            txtNumber.Text = "";
            txtNumber.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
