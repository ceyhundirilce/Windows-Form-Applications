using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            checkedListBox1.Items.Add("BMW");
            checkedListBox1.Items.Add("Bugatti");
            checkedListBox1.Items.Add("Audi");
            checkedListBox1.Items.Add("Porsche");
            checkedListBox1.Items.Add("Volkswagen");
            checkedListBox1.Items.Add("Nissan");
            checkedListBox1.Items.Add("Honda");
            checkedListBox1.Items.Add("Ferrari");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            {
                int hepsi = checkedListBox1.Items.Count;
                for (int i = 0; i < hepsi; i++)
                {
                    checkedListBox1.SetItemChecked(i, true);
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int hepsi = checkedListBox1.Items.Count;
            for (int i = 0; i < hepsi; i++)
            {
                checkedListBox1.SetItemChecked(i, false);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Contains(checkedListBox1.Text) == false)
            {
                for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
               {
                    listBox1.Items.Add(checkedListBox1.CheckedItems[i]);

                    int a = listBox1.Items.Count;
                    label3.Text = a + " adet araba satıldı";
                }
            }
            else
            {
            MessageBox.Show("Tekrarlı Bilgi", "Uyarı");
            }          
        }
        private void button4_Click(object sender, EventArgs e)
        {
            int hepsi = checkedListBox1.Items.Count;
            for (int i = 0; i < hepsi; i++)
            {
                checkedListBox1.SetItemChecked(i, false);
            }
            listBox1.Items.Clear();
            label3.Text = "";
            checkedListBox1.Text = "";
        }

     
    }
}
