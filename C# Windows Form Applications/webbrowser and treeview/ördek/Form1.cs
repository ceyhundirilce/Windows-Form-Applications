using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ördek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btn_kateekle_Click(object sender, EventArgs e)
        {
            //KATEGORİ KODLARI
            TreeNode secilen;
            secilen = treeView1.SelectedNode;
            treeView1.Nodes.Add(txt_kateisim.Text);
            txt_kateisim.Clear();
        }
        private void btn_altkateekle_Click(object sender, EventArgs e)
        {
            //ALT KATEGORİ EKLEME KODLARI
            TreeNode secilen;
            secilen = treeView1.SelectedNode;
            secilen.Nodes.Add(txt_kateisim.Text);
            txt_kateisim.Clear();
        }
        private void btn_katesil_Click(object sender, EventArgs e)
        {
            //SEÇİLEN KATEGORİYİ SİLME KODU
            TreeNode secilen;
            secilen = treeView1.SelectedNode;
            if (!(secilen.Parent == null))
            {
                secilen.Parent.Nodes.Remove(secilen);
            }
            else
            {
                treeView1.Nodes.Remove(secilen);
            }
        }
        private void btn_kategoster_Click(object sender, EventArgs e)
        {
            //KATEGORİLERİ GÖSTERME KODU
            treeView1.ExpandAll();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            //İLERİ SEKMEYE GİTME KODU
            webBrowser1.GoForward();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            //GERİ SEKMEYE GİTME KODU
            webBrowser1.GoBack();
        }
        private void btn_googleara_Click(object sender, EventArgs e)
        {
            //ARAMA MOTORU KODU
            if (txt_motor.Text.Length > 1)
            {
                webBrowser1.Navigate("https://www.google.com/search?q=" + txt_motor.Text);
            }
            else
            {
                webBrowser1.Navigate("https://www.google.com");
            }
        }
    }
}
