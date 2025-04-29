using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace gp
{
    public partial class Odeme : Form
    {
        public Odeme()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\emirh\OneDrive\Belgeler\SporDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void FillName()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select UAdSoyad from Uyetbl", baglanti);
            SqlDataReader rdr;
            rdr = komut.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("UAdSoyad", typeof(string));
            dt.Load(rdr);
            AdSoyadCb.ValueMember = "UAdSoyad";
            AdSoyadCb.DataSource = dt;
            baglanti.Close();

        }
        private void Adfiltrele()
        {
            baglanti.Open();
            string query = "Select * from OdemeTbl where OUye='" + AraTb.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, baglanti);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            OdemeDGV.DataSource = ds.Tables[0];
            baglanti.Close();
        }
        private void uyeler()
        {
            baglanti.Open();
            string query = "Select * from OdemeTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, baglanti);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            OdemeDGV.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            AdSoyadCb.Text = "";
            OdemeTb.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AnaSayfa anaSayfa = new AnaSayfa();
            anaSayfa.Show();
            this.Hide();
        }

        private void Odeme_Load(object sender, EventArgs e)
        {
            FillName();
            uyeler();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (AdSoyadCb.Text == "" || OdemeTb.Text == "")
            {
                MessageBox.Show("Eksik bilgi");
            }
            else
            {
                string odemeperiyot = Periyot.Value.Month.ToString() + "/" + Periyot.Value.Year.ToString();
                baglanti.Open();
                SqlDataAdapter sda = new SqlDataAdapter("Select count(*) from OdemeTbl where OUye='" + AdSoyadCb.SelectedValue.ToString() + "' and OAy='" + odemeperiyot + "'", baglanti);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    MessageBox.Show("Bu ay için ödeme yapılmıştır.");
                }
                else
                {
                    string query = "Insert into OdemeTbl values('" + odemeperiyot + "','" + AdSoyadCb.SelectedValue.ToString() + "','" + OdemeTb.Text + "')";
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Ödeme Başarıyla Alındı");
                }
                baglanti.Close();
                uyeler();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Adfiltrele();
            AraTb.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            uyeler();
        }
    }
}
