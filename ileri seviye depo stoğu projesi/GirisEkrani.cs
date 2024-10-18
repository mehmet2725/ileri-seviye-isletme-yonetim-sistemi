using System.Data;
using MySql.Data.MySqlClient;

namespace ileri_seviye_depo_stoğu_projesi
{
    public partial class GirisEkrani : Form
    {
        public GirisEkrani()
        {
            InitializeComponent();
        }
        private void btn_musteri_Click(object sender, EventArgs e)
        {
            MusteriEkrani musteriekrani = new MusteriEkrani();
            musteriekrani.Show();
            this.Hide();
        }

        private void GirisEkrani_Load(object sender, EventArgs e)
        {

        }

        private void btn_calisan_Click(object sender, EventArgs e)
        {
            Calisan_Ekrani calisan_Ekrani = new Calisan_Ekrani();
            calisan_Ekrani.Show();
            this.Hide();
        }

        private void btn_yonetici_Click(object sender, EventArgs e)
        {
            Yonetici_ekrani yonetici_Ekrani=new Yonetici_ekrani();
            yonetici_Ekrani.Show();
            this.Hide();
        }
    }
}
