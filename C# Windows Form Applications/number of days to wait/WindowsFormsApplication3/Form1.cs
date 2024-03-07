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

        private void button1_Click(object sender, EventArgs e)
        {

         
            int ab = Convert.ToInt32(numericUpDown1.Text);
            label1.Text = dateTimePicker1.Value.AddDays(ab).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
