using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
     
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text=="Honda")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Civic");
                     
            }
            else if (comboBox1.Text == "Renault")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Clio");
             
            }
            else if (comboBox1.Text == "Fiat")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Doblo");         
            }
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text== "Civic")
            {
                pictureBox1.ImageLocation = "indir.jpg";
            }
            else if (comboBox2.Text == "Clio")
            {
                pictureBox1.ImageLocation = "namazclio.jpg";
            }
            else if (comboBox2.Text == "Doblo")
            {
                pictureBox1.ImageLocation = "p0519035.jpg";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            
        }
    }
}
