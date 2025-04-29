namespace gp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            KullaniciTb.Text = "";
            SifreTb.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(KullaniciTb.Text==""||SifreTb.Text=="")
            {
                MessageBox.Show("Eksik Bilgi");
            }
            else if(KullaniciTb.Text=="Admin"&&SifreTb.Text=="1234")
            {
                AnaSayfa anasayfa = new AnaSayfa();
                anasayfa.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalý Kullanýcý Adý ya da Þifre Giriþi");
            }
        }
    }
}
