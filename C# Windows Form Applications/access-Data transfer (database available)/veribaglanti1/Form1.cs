using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;  // Access bağlantısı kurabilmek için.
using System.Collections; //ArrayList kullanabilmek için.
namespace veribaglanti1
{
    public partial class Form1 : Form
    {
        OleDbConnection con;
        OleDbDataAdapter da;
        OleDbCommand cmd;
        OleDbDataReader dr;
        DataSet ds;

        public Form1()
        {
            InitializeComponent();
        }
        void griddoldur()
        {
            con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=okul.accdb");
            da = new OleDbDataAdapter("SElect *from ogrenci", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "ogrenci");
            dataGridView1.DataSource = ds.Tables["ogrenci"];
            con.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            griddoldur();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "insert into ogrenci (ogr_no,ogr_ad,ogr_soyad,ogr_tel) values ('" + tbno.Text + "','" + tbad.Text + "','" + tbsoyad.Text + "','" + tbtel.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            griddoldur();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "update ogrenci set ogr_ad='" + tbad.Text + "',ogr_soyad='" + tbsoyad.Text + "',ogr_tel='" + tbtel.Text + "' where ogr_no="+tbno.Text+"";
            cmd.ExecuteNonQuery();
            con.Close();
            griddoldur();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "delete from ogrenci where ogr_no="+tbno.Text+"";
            cmd.ExecuteNonQuery();
            con.Close();
            griddoldur();
        }

      
        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            tbno.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            tbad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            tbsoyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            tbtel.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=okul.accdb");
            da = new OleDbDataAdapter("SElect *from ogrenci where ogr_ad like '"+textBox5.Text+"%'", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "ogrenci");
            dataGridView1.DataSource = ds.Tables["ogrenci"];
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM ogrenci";
            dr = cmd.ExecuteReader();
            
            ArrayList Isimler = new ArrayList(); 


            while (dr.Read())
            {
               Isimler.Add(dr["ogr_ad"]); // istersek arraylist'e atabiliriz.
               listBox1.Items.Add(dr["ogr_no"]);
               listBox2.Items.Add(dr["ogr_ad"]);
               listBox3.Items.Add(dr["ogr_soyad"]);
               listBox4.Items.Add(dr["ogr_tel"]);
            }
            foreach (string eleman in Isimler)
            {
                listBox5.Items.Add(eleman);
            }

            dr.Close();
            con.Close(); 
        }

        private void button5_Click(object sender, EventArgs e)
        {

            int kayitSayisi;
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT COUNT(*) FROM ogrenci";
            kayitSayisi =(int) cmd.ExecuteScalar() ;
            con.Close();
            MessageBox.Show(kayitSayisi.ToString());
        }

     

      
    }
}
