using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9._12._19_maskedtxtbox_ve_listbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            string[] elemanlar = { mskd_kayıt.Text, mskd_kimlik.Text, txt_baba.Text, mskd_tel.Text, txt_ad.Text, txt_anneKizlik.Text, txt_soyad.Text, txt_anne.Text };
            ListViewItem satir = new ListViewItem(elemanlar);
            listView1.Items.Add(satir);

            mskd_kayıt.Text ="";
            mskd_kimlik.Text = "";
            txt_baba.Text = "";
            mskd_tel.Text = "";
            txt_ad.Text = "";
            txt_anneKizlik.Text = "";
            txt_soyad.Text = "";
            txt_anne.Text = "";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;

            //listview in içine başlık ekliyoruz
            listView1.Columns.Add("Kayıt Tarihi", 100);
            listView1.Columns.Add("TC Kimlik No", 100);
            listView1.Columns.Add("Ad", 100);
            listView1.Columns.Add("Soyad", 100);
            listView1.Columns.Add("Sınıf/Şube", 100);
            listView1.Columns.Add("No", 50);
            listView1.Columns.Add("Telefon No", 100);
            listView1.Columns.Add("Okul Adı", 100);
      
        }
        private void btn_sil_Click(object sender, EventArgs e)
        {
            for (int i = listView1.Items.Count -1;  i>=0; i--)
            {
                if (listView1.Items[i].Selected)                  
                {
                    listView1.Items[i].Remove();
                }
            }
        }
    }
}
