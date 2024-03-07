using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string a, b;
        }

        string a;
        int sayi;
        private void button1_Click(object sender, EventArgs e)
        {
            a = "";
            if (radioButton1.Checked )
            {
                a = "buyuk";
                char gelenharf = harfuret(a);
                listBox1.Items.Add(gelenharf);

            }
            else if (radioButton2.Checked)
            {
                a = "kucuk";
                char gelenharf = harfuret(a);
                listBox1.Items.Add(gelenharf);
            }
            else if (a == "")
            {
                MessageBox.Show("Büyük Ya Da Küçük Harf Seçiniz");
            }
        

        }

        char harfuret (string a)
        {
            Random rnd = new Random();
            int sayi = 0;
            if (a=="buyuk")
            {
                sayi = rnd.Next(65,91);
            }
            else if (a=="kucuk")
            {
                sayi = rnd.Next(97,123);
            }
            char harf = Convert.ToChar(sayi);
            return harf;
        }
    }
}
