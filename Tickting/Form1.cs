﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tickting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            ticket aTicket = new ticket();
            aTicket.name = nametextBox.Text;
            aTicket.number = Convert.ToInt32(numbertextBox.Text);

            totaltextBox.Text = aTicket.total().ToString();
            MessageBox.Show("Mr. " + nametextBox.Text + "  You pay " + totaltextBox.Text);
        }
    }
}
