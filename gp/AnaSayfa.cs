using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gp
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UyeEkle uyeEkle = new UyeEkle();
            uyeEkle.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GuncelleSil guncelle = new GuncelleSil();
            guncelle.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Odeme odeme = new Odeme();
            odeme.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UyeleriGoruntule uyeleriGoruntule = new UyeleriGoruntule();
            uyeleriGoruntule.Show();
            this.Hide();
        }
    }
}
