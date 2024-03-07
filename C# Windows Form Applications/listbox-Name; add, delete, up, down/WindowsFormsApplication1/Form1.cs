using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void sirala_Click(object sender, EventArgs e)
        {
            listBox1.Sorted = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string isim;
            isim = textBox1.Text;
            listBox1.Items.Add(isim);
            textBox1.Clear();
            textBox1.Focus();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            int a = listBox1.SelectedIndex;
            string y = "";
            if (a!=0)
            {
                listBox1.Sorted = false;
                y = listBox1.SelectedItem.ToString();
                listBox1.Items.Remove(y);
                listBox1.Items.Insert(a - 1, y);
                listBox1.SelectedItem = y;
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            int a = listBox1.SelectedIndex;
            string y = "";

            if (a != listBox1.Items.Count-1 )
            {
                listBox1.Sorted = false;
                y = listBox1.SelectedItem.ToString();
                listBox1.Items.Remove(y);
                listBox1.Items.Insert(a + 1, y);
                listBox1.SelectedItem = y;
            }
    }
        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
    }
