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
    public partial class UyeEkle : Form
    {
        public UyeEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\emirh\OneDrive\Belgeler\SporDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UyeEkle_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (AdSoyadTb.Text == "" || TelefonTb.Text == "" || OdemeTb.Text == "" || YasTb.Text == "" ||
                CinsiyetCb.SelectedItem == null || ZamanlamaCb.SelectedItem == null)
            {
                MessageBox.Show("Eksik bilgi");
            }
            else
            {
                try
                {
                    baglanti.Open();
                    string query = "Insert into Uyetbl values('" + AdSoyadTb.Text + "','" + TelefonTb.Text + "','" +
                                   CinsiyetCb.SelectedItem?.ToString() + "','" + YasTb.Text + "','" + OdemeTb.Text + "','" +
                                   ZamanlamaCb.SelectedItem?.ToString() + "')";
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Üye Başarıyla Eklendi");
                    baglanti.Close();
                    AdSoyadTb.Text = "";
                    TelefonTb.Text = "";
                    CinsiyetCb.Text = "";
                    YasTb.Text = "";
                    OdemeTb.Text = "";
                    ZamanlamaCb.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AdSoyadTb.Text = "";
            TelefonTb.Text = "";
            CinsiyetCb.Text = "";
            YasTb.Text = "";
            OdemeTb.Text = "";
            ZamanlamaCb.Text = "";
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AnaSayfa anaSayfa = new AnaSayfa();
            anaSayfa.Show();
            this.Hide();
        }
    }
}
