﻿using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Guna.UI2.Native.WinApi;

namespace gp
{
    public partial class UyeleriGoruntule : Form
    {
        public UyeleriGoruntule()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\emirh\OneDrive\Belgeler\SporDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void uyeler()
        {
            baglanti.Open();
            string query = "Select * from Uyetbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, baglanti);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            UyeDGV.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UyeleriGoruntule_Load(object sender, EventArgs e)
        {
            uyeler();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AnaSayfa anaSayfa = new AnaSayfa();
            anaSayfa.Show();
            this.Hide();
        }
        private void Adfiltrele()
        {
            baglanti.Open();
            string query = "Select * from UyeTbl where UAdSoyad='" + AraUyeTb.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, baglanti);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            UyeDGV.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Adfiltrele();
            AraUyeTb.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            uyeler();
        }
    }
}
