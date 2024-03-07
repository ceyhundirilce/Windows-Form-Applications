using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace radioButton2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double urunFiyati = Convert.ToInt32(textBox1.Text);
            double kdv = 0;
            double aylik = 0;
          
            if (rb_bonus.Checked==true)
            {
                double kdv1 = urunFiyati + urunFiyati* 0.05;
                aylik = kdv1 / 15;
                textBox3.Text = aylik.ToString() ;
                textBox2.Text = kdv1.ToString();
            }
           
            if (rb_access.Checked==true)
            {
                double kdv2 = urunFiyati + urunFiyati * 0.10;
                aylik = kdv2 / 10;
                textBox3.Text = aylik.ToString();
                textBox2.Text = kdv2.ToString();
            }
        
            if (rb_maxsimum.Checked==true)
            {
               double kdv3 = urunFiyati + urunFiyati * 0.03;
                aylik = kdv3 / 9;
                textBox3.Text = aylik.ToString();
                textBox2.Text = kdv3.ToString();
            }
          
            if (rb_tekCekim.Checked==true)
            {
               double kdv4 = urunFiyati - urunFiyati * 0.05;
                textBox3.Text = "0";
                textBox2.Text = kdv4.ToString();
            }
            
        }
    }
}
