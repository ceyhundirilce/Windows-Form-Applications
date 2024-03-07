using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button2.Enabled = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
          

        }
        
        int sayac = 0;
        DateTime d1;
        DateTime d2;


        private void button1_Click(object sender, EventArgs e)
        {

            sayac++;
            DateTime time = dateTimePicker1.Value;
            if (sayac==1)
            {
                d1 = time;
                label1.Text = time.ToLongDateString();

            }
            else if (sayac==2)
            {
                button2.Enabled = true;

                d2 = time;
               label2.Text = time.ToLongDateString();

                    
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Text = "fark" + (d1-d2).Days.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sayac = 0;
            label1.Text="Birinci Tarih";
            label2.Text = "İkinci Tarih";
            label3.Text = "FARK";
        }
    }
}
