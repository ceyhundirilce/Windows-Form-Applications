using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label9.Visible = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
          
            label3.Text = comboBox1.Text;
            label4.Text = comboBox2.Text;
            comboBox1.Enabled = false;
            comboBox2.Enabled = false;
            timer1.Start();


        }
        int sn = 0;
        int dk = 0;


        private void timer1_Tick(object sender, EventArgs e)
        {
            sn++;
            label6.Text = sn.ToString();

            if (sn==59)
            {
                sn = -1;
                dk++;
                label5.Text = dk.ToString();
            }
            if (label5.Text == label3.Text && label6.Text == label4.Text)
            {

                timer1.Stop();
                
                label9.Visible = true;
                button1.Enabled = false;


            }
               
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();

            button1.Enabled = true;
            comboBox1.Enabled = true;
            comboBox2.Enabled = true;
            label3.Text = "0";
            label4.Text = "0";
            label5.Text = "0";
            label6.Text = "0";
            label9.Visible = false;
            comboBox1.Text = "";
            comboBox2.Text = "";
            sn = 0;
            dk = 0;

        }
    }
}
