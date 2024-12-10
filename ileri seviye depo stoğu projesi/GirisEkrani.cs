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


        private void GirisEkrani_Load(object sender, EventArgs e)
        {

        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            // Giriş ekranındaki textbox'lardan kullanıcı adı ve şifreyi alıyoruz.
            string kullaniciAdi = txt_kulAd.Text;
            string sifre = txt_sifre.Text;
            string connectionString = "Server=localhost;Database=bitirme_projesi;Uid=root;Pwd=138426;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT kullanici_id, rol, erisim_siparis, erisim_stok FROM Kullanicilar WHERE eposta = @kullaniciAdi AND sifre = @sifre";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);
                    command.Parameters.AddWithValue("@sifre", sifre);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int ilgiliId = reader.GetInt32("kullanici_id");
                            string rol = reader.GetString("rol");
                            bool erisimSiparis = reader.GetBoolean("erisim_siparis");
                            bool erisimStok = reader.GetBoolean("erisim_stok");

                            if (rol == "Yonetici")
                            {
                                Yonetici_ekrani yoneticiForm = new Yonetici_ekrani();
                                yoneticiForm.Show();
                            }
                            else if (rol == "Calisan")
                            {
                                Calisan_Ekrani calisanForm = new Calisan_Ekrani(erisimSiparis, erisimStok);
                                calisanForm.Show();
                            }
                            else if (rol == "Musteri")
                            {
                                MusteriEkrani musteriForm = new MusteriEkrani(ilgiliId);
                                musteriForm.Show();
                            }
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Kullanıcı adı veya şifre yanlış!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }
    }
}
