using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random sayi = new Random();
        int rakam;
        int tsayi;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
            
            rakam = sayi.Next(1,10);
            label2.Text = rakam.ToString();
            switch (rakam)
            {
                case 9:
                    button1.BackColor = Color.Black;
                    button2.BackColor = Color.Black;
                    button3.BackColor = Color.Black;
                    button4.BackColor = Color.Black;
                    button5.BackColor = Color.Black;
                    button6.BackColor = Color.White;
                    button7.BackColor = Color.Black;
                    break;


                case 8:
                    button1.BackColor = Color.Black;
                    button2.BackColor = Color.Black;
                    button3.BackColor = Color.Black;
                    button4.BackColor = Color.Black;
                    button5.BackColor = Color.Black;
                    button6.BackColor = Color.Black;
                    button7.BackColor = Color.Black;

                    break;

                case 7: 
                    button1.BackColor = Color.Black;
                    button2.BackColor = Color.Black;
                    button3.BackColor = Color.White;
                    button4.BackColor = Color.Black;
                    button5.BackColor = Color.Black;
                    button6.BackColor = Color.White;
                    button7.BackColor = Color.White;

                    break;

                case 6:
                    button1.BackColor = Color.Black;
                    button2.BackColor = Color.Black;
                    button3.BackColor = Color.Black;
                    button4.BackColor = Color.White;
                    button5.BackColor = Color.Black;
                    button6.BackColor = Color.Black;
                    button7.BackColor = Color.Black;
                    break;
                case 5: 
                    button1.BackColor = Color.Black;
                    button2.BackColor = Color.Black;
                    button3.BackColor = Color.Black;
                    button4.BackColor = Color.White;
                    button5.BackColor = Color.Black;
                    button6.BackColor = Color.White;
                    button7.BackColor = Color.Black;
                    break;
                case 4:
                    button1.BackColor = Color.White;
                    button2.BackColor = Color.Black;
                    button3.BackColor = Color.Black;
                    button4.BackColor = Color.Black;
                    button5.BackColor = Color.Black;
                    button6.BackColor = Color.White;
                    button7.BackColor = Color.White;
                    break;
                case 3:
                    button1.BackColor = Color.Black;
                    button2.BackColor = Color.White;
                    button3.BackColor = Color.Black;
                    button4.BackColor = Color.Black;
                    button5.BackColor = Color.Black;
                    button6.BackColor = Color.White;
                    button7.BackColor = Color.Black;
                    break;

                case 2: 
                    button1.BackColor = Color.Black;
                    button2.BackColor = Color.White;
                    button3.BackColor = Color.Black;
                    button4.BackColor = Color.Black;
                    button5.BackColor = Color.White;
                    button6.BackColor = Color.Black;
                    button7.BackColor = Color.Black;
                    break;

                case 1:
                    button1.BackColor = Color.White;
                    button2.BackColor = Color.White;
                    button3.BackColor = Color.White;
                    button4.BackColor = Color.Black;
                    button5.BackColor = Color.Black;
                    button6.BackColor = Color.White;
                    button7.BackColor = Color.White;
                    break;





                default:
                    break;
            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tsayi++;
            if (tsayi==9)
            {
                timer1.Stop();
                tsayi = 0;
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
            }
        }
    }
}
