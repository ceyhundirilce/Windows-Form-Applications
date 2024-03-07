using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace harfhesap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 0, b = 0, c = 0, ç = 0, d = 0, ee = 0, f = 0, g = 0, ğ = 0, h = 0, j = 0, ı = 0, ii = 0, k = 0, l = 0, m = 0, n = 0, o = 0, ö = 0, p = 0, r = 0, s = 0, ş = 0, t = 0, u = 0, ü = 0, v = 0, y = 0, z = 0;
            string cumle = Convert.ToString(textBox1.Text);
            for (int i = 0; i < cumle.Length; i++)
            {
                if (cumle.ToLower()[i] == 'a')
                {
                    a = a + 1;
                }
                else if (cumle.ToLower()[i] == 'b')
                {
                    b = b + 1;
                }
                else if (cumle.ToLower()[i] == 'c')
                {
                    c = c + 1;
                }
                else if (cumle.ToLower()[i] == 'ç')
                {
                    ç = ç + 1;
                }
                else if (cumle.ToLower()[i] == 'd')
                {
                    d = d + 1;
                }
                else if (cumle.ToLower()[i] == 'e')
                {
                    ee = ee + 1;
                }
                else if (cumle.ToLower()[i] == 'f')
                {
                    f = f + 1;
                }
                else if (cumle.ToLower()[i] == 'g')
                {
                    g = g + 1;
                }
                else if (cumle.ToLower()[i] == 'ğ')
                {
                    ğ = ğ + 1;
                }
                else if (cumle.ToLower()[i] == 'h')
                {
                    h = h + 1;
                }
                else if (cumle.ToLower()[i] == 'j')
                {
                    j = j + 1;
                }
                else if (cumle.ToLower()[i] == 'ı')
                {
                    ı = ı + 1;
                }
                else if (cumle.ToLower()[i] == 'i')
                {
                    i = i + 1;
                }

                else if (cumle.ToLower()[i] == 'k')
                {
                    k = k + 1;
                }
                else if (cumle.ToLower()[i] == 'l')
                {
                    l = l + 1;
                }
                else if (cumle.ToLower()[i] == 'm')
                {
                    m = m + 1;
                }
                else if (cumle.ToLower()[i] == 'n')
                {
                    n = n + 1;
                }
                else if (cumle.ToLower()[i] == 'o')
                {
                    o = o + 1;
                }
                else if (cumle.ToLower()[i] == 'ö')
                {
                    ö = ö + 1;
                }
                else if (cumle.ToLower()[i] == 'p')
                {
                    p = p + 1;
                }
                else if (cumle.ToLower()[i] == 'r')
                {
                    r = r + 1;
                }
                else if (cumle.ToLower()[i] == 's')
                {
                    s = s + 1;
                }
                else if (cumle.ToLower()[i] == 'ş')
                {
                    ş = ş + 1;
                }
                else if (cumle.ToLower()[i] == 't')
                {
                    t = t + 1;
                }
                else if (cumle.ToLower()[i] == 'u')
                {
                    u = u + 1;
                }
                else if (cumle.ToLower()[i] == 'ü')
                {
                    ü = ü + 1;
                }

                else if (cumle.ToLower()[i] == 'v')
                {
                    v = v + 1;
                }
                else if (cumle.ToLower()[i] == 'y')
                {
                    y = y + 1;
                }
                else if (cumle.ToLower()[i] == 'z')
                {
                    z = z + 1;
                }
                label1.Text = "A harfi = " + a.ToString();
                label2.Text = "B harfi = " + b.ToString();
                label3.Text = "C harfi = " + c.ToString();
                label4.Text = "Ç harfi = " + ç.ToString();
                label5.Text = "D harfi = " + d.ToString();
                label6.Text = "E harfi = " + ee.ToString();
                label7.Text = "F harfi = " + f.ToString();
                label8.Text = "G harfi = " + g.ToString();
                label9.Text = "Ğ harfi = " + ğ.ToString();
                label10.Text = "H harfi = " + h.ToString();
                label11.Text = "I harfi = " + ı.ToString();
                label12.Text = "İ harfi = " + ii.ToString();
                label13.Text = "J harfi = " + j.ToString();
                label14.Text = "K harfi = " + k.ToString();
                label15.Text = "L harfi = " + l.ToString();
                label16.Text = "M harfi = " + m.ToString();
                label17.Text = "N harfi = " + n.ToString();
                label18.Text = "O harfi = " + o.ToString();
                label19.Text = "Ö harfi = " + ö.ToString();
                label20.Text = "P harfi = " + p.ToString();
                label21.Text = "R harfi = " + r.ToString();
                label22.Text = "S harfi = " + s.ToString();
                label23.Text = "Ş harfi = " + ş.ToString();
                label24.Text = "T harfi = " + t.ToString();
                label25.Text = "U harfi = " + u.ToString();
                label26.Text = "Ü harfi = " + ü.ToString();
                label27.Text = "V harfi = " + v.ToString();
                label28.Text = "Y harfi = " + y.ToString();
                label29.Text = "Z harfi = " + z.ToString();

                textBox1.Clear();
            }
        }      
    }
}