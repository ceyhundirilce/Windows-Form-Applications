﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
         // notifyIcon1.ShowBalloonTip(30000,textBox1.Text,textBox2.Text, ToolTipIcon.Info);
            notifyIcon1.ShowBalloonTip(3000,textBox1.Text,textBox2.Text,ToolTipIcon.Error);
        }
        private void kAPATToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void gÖSTERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }
        private void gİZLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void selamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("selam");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
