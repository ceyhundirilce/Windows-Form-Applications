using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace richtextbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            fntdiyalog.ShowDialog();
            richTextBox1.SelectionFont = fntdiyalog.Font;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            fntdiyalog.ShowDialog();
            richTextBox1.Font = fntdiyalog.Font;
        }
        private void btn_rnk_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            richTextBox1.SelectionColor = colorDialog1.Color;
        }
        private void btn_arnk_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            richTextBox1.SelectionBackColor = colorDialog1.Color;
        }
        private void btn_kyd_Click(object sender, EventArgs e)
        {
            saveFileDialog1.DefaultExt = "*.txt";
            saveFileDialog1.Filter = "TXT Files|*.txt";
            saveFileDialog1.ShowDialog();
            richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
        }
        private void btn_ac_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);
        }
    }
}

