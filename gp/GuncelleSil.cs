using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Microsoft.Data.SqlClient;

namespace gp
{
    public partial class GuncelleSil : Form
    {
        public GuncelleSil()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\emirh\OneDrive\Belgeler\SporDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void uyeler()
        {
            baglanti.Open();
            string query = "Select * from Uyetbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, baglanti);
            SqlCommandBuilder scb = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            UyeDGV.DataSource = ds.Tables[0];
            baglanti.Close();
        }
        private void GuncelleSil_Load(object sender, EventArgs e)
        {
            uyeler();
        }
        int key = 0;
        private void UyeDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            key = Convert.ToInt32(UyeDGV.SelectedRows[0].Cells[0].Value.ToString());
            AdSoyadTb.Text = UyeDGV.SelectedRows[0].Cells[1].Value.ToString();
            TelefonTb.Text = UyeDGV.SelectedRows[0].Cells[2].Value.ToString();
            CinsiyetCb.Text = UyeDGV.SelectedRows[0].Cells[3].Value.ToString();
            YasTb.Text = UyeDGV.SelectedRows[0].Cells[4].Value.ToString();
            OdemeTb.Text = UyeDGV.SelectedRows[0].Cells[5].Value.ToString();
            ZamanlamaCb.Text = UyeDGV.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void button5_Click(object sender, EventArgs e)
        {
            AnaSayfa anaSayfa = new AnaSayfa();
            anaSayfa.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Silinecek Üyeyi Seçiniz");
            }
            else
            {
                try
                {
                    baglanti.Open();
                    string query = "delete from Uyetbl where UId=" + key + ";";
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Üye Başarıyla Silindi");
                    baglanti.Close();
                    uyeler();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (key == 0 || AdSoyadTb.Text==""|| TelefonTb.Text=="" || CinsiyetCb.Text==""||YasTb.Text==""||OdemeTb.Text==""||ZamanlamaCb.Text=="")
            {
                MessageBox.Show("Eksik Bilgi");
            }
            else
            {
                try
                {
                    baglanti.Open();
                    string query = "update Uyetbl set UAdSoyad='"+AdSoyadTb.Text+"',UTelefon='"+TelefonTb.Text+"',Cinsiyet='"+CinsiyetCb.Text+"',UYas='"+YasTb.Text+"',Odeme='"+OdemeTb.Text+"',UZamanlama='"+ZamanlamaCb.Text+"'where UId="+key+";";
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Üye Başarıyla Güncellendi");
                    baglanti.Close();
                    uyeler();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
