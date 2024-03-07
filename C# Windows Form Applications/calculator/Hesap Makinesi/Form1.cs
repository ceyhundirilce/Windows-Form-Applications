using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hesap_Makinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        char islem;
        bool ekranTemizlecekMi;
        double sayi1,sayi2,sonuc;

        private void btn_1_Click(object sender, EventArgs e)
        {
            if (ekranTemizlecekMi)
            {
                lbl_ekran.Text = null;
                ekranTemizlecekMi = false;
            }
            if (lbl_ekran.Text == "0")
            {
                lbl_ekran.Text = null;
            }
            lbl_ekran.Text += 1;
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            if (ekranTemizlecekMi)
            {
                lbl_ekran.Text = null;
                ekranTemizlecekMi = false;
            }
            if (lbl_ekran.Text == "0")
            {
                lbl_ekran.Text = null;
            }
            lbl_ekran.Text += 2;
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            if (ekranTemizlecekMi)
            {
                lbl_ekran.Text = null;
                ekranTemizlecekMi = false;
            }
            if (lbl_ekran.Text == "0")
            {
                lbl_ekran.Text = null;
            }
            lbl_ekran.Text += 3;
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            if (ekranTemizlecekMi)
            {
                lbl_ekran.Text = null;
                ekranTemizlecekMi = false;
            }
            if (lbl_ekran.Text == "0")
            {
                lbl_ekran.Text = null;
            }
            lbl_ekran.Text += 4;
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            if (ekranTemizlecekMi)
            {
                lbl_ekran.Text = null;
                ekranTemizlecekMi = false;
            }
            if (lbl_ekran.Text == "0")
            {
                lbl_ekran.Text = null;
            }
            lbl_ekran.Text += 5;
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            if (ekranTemizlecekMi)
            {
                lbl_ekran.Text = null;
                ekranTemizlecekMi = false;
            }
            if (lbl_ekran.Text == "0")
            {
                lbl_ekran.Text = null;
            }
            lbl_ekran.Text += 6;
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            if (ekranTemizlecekMi)
            {
                lbl_ekran.Text = null;
                ekranTemizlecekMi = false;
            }
            if (lbl_ekran.Text == "0")
            {
                lbl_ekran.Text = null;
            }
            lbl_ekran.Text += 7;
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            if (ekranTemizlecekMi)
            {
                lbl_ekran.Text = null;
                ekranTemizlecekMi = false;
            }
            if (lbl_ekran.Text == "0")
            {
                lbl_ekran.Text = null;
            }
            lbl_ekran.Text += 8;
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            if (ekranTemizlecekMi)
            {
                lbl_ekran.Text = null;
                ekranTemizlecekMi = false;
            }
            if (lbl_ekran.Text == "0")
            {
                lbl_ekran.Text = null;
            }
            lbl_ekran.Text += 9;
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            if (ekranTemizlecekMi)
            {
                lbl_ekran.Text = null;
                ekranTemizlecekMi = false;
            }
            if (lbl_ekran.Text == "0")
            {
                lbl_ekran.Text = null;
            }
            lbl_ekran.Text += 0;
        }
        private void btn_topla_Click(object sender, EventArgs e)
        {
            islem = '+';
            ekranTemizlecekMi = true;
            sayi1 = Convert.ToInt64(lbl_ekran.Text);
        }
        private void btn_cikar_Click(object sender, EventArgs e)
        {
            islem = '-';
            ekranTemizlecekMi = true;
            sayi1 = Convert.ToInt64(lbl_ekran.Text);
        }
        private void btn_carp_Click(object sender, EventArgs e)
        {
            islem = '*';
            ekranTemizlecekMi = true;
            sayi1 = Convert.ToInt64(lbl_ekran.Text);
        }

        private void btn_bol_Click(object sender, EventArgs e)
        {
            islem = '/';
            ekranTemizlecekMi = true;
            sayi1 = Convert.ToInt64(lbl_ekran.Text);
        }       

        private void btn_esittir_Click(object sender, EventArgs e)
        {
            sayi2 = Convert.ToInt64(lbl_ekran.Text);
            switch (islem)
            {
                case '+':
                    sonuc = sayi1 + sayi2;
                    break;
                case '-':
                    sonuc = sayi1 - sayi2;
                    break;
                case '*':
                    sonuc = sayi1 * sayi2;
                    break;
                case '/':
                    sonuc = sayi1 / sayi2;
                    break;
                default:
                    sonuc = 0;
                    break;
            }
            lbl_ekran.Text = Convert.ToString(sonuc);
        }
        private void btn_temizle_Click(object sender, EventArgs e)
        {
            lbl_ekran.Text = "0";
        }
    }
}
