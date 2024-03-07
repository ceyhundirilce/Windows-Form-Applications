using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string ad = textBox1.Text;
            int a = textBox2.Text.Length;
            if (a == 0)
            {
                label1.Text = "";
                progressBar1.Value = 0;
                label3.Text = "";            
            }
            else if (a <= 4)
            {
                progressBar1.Value = 25;
                label1.ForeColor = Color.Green;
                progressBar1.ForeColor = Color.Green;
                label1.Text = "Kolay";
                label3.Text = "Çok Kötü";           
            }
            else if (a > 4 && a <= 8)
            {
                progressBar1.Value = 50;
                label1.ForeColor = Color.Yellow;
                progressBar1.ForeColor = Color.Yellow;
                label1.Text = "Orta";
                label3.Text = "İdare Eder";               
            }
            else if (a > 8 && a <= 11)
            {
                progressBar1.Value = 75;
                label1.ForeColor = Color.Orange;
                progressBar1.ForeColor = Color.Orange;
                label1.Text = "Zor";
                label3.Text = "Mükemmel";             
            }
            else if (a >= 12 && a <= 15)
            {
                progressBar1.Value = 100;
                label1.ForeColor = Color.Red;
                progressBar1.ForeColor = Color.Red;
                label1.Text = "Çok Zor";
                label3.Text = "Efsane";             
            }
            else
            {
                textBox2.MaxLength = 15;
                label1.ForeColor = Color.Black;
                progressBar1.ForeColor = Color.Black;
                label1.Text = "Daha Olmaz";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add(textBox2.Text);
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            label1.Text = "";
            label3.Text = "";
            listBox1.ClearSelected();
            listBox2.ClearSelected();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.MaxLength = 20;
        }
    }  
}
