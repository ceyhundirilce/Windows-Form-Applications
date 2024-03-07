using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int [] sayi = new int[10];
        Random rnd = new Random();

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                sayi[i] = rnd.Next(1,101);
                listBox1.Items.Add(sayi[i]);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 9; i >=0; i--)
            {
                listBox2.Items.Add(sayi[i]);
            }
            Array.Sort(sayi);
            foreach (int duzen in sayi)
            {
                listBox3.Items.Add(duzen);
            }
            Array.Reverse(sayi);
            foreach (int duzen in sayi) 
            {
                listBox4.Items.Add(duzen);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
        }
    }
}
