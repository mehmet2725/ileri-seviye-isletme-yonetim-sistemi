using System;
using System.Data;
using System.Windows.Forms;
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
            // Form yüklendiğinde yapılacak işlemler (şimdilik boş bırakıldı).
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            // Giriş ekranındaki textbox'lardan kullanıcı adı ve şifreyi alıyoruz.
            string kullaniciAdi = txt_kulAd.Text;
            string sifre = txt_sifre.Text;

            // Veritabanı bağlantı bilgileri.
            string connectionString = "Server=localhost;Database=bitirme_projesi;Uid=root;Pwd=138426;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT kullanici_id, rol, ilgili_tablo_id FROM kullanicilar WHERE eposta = @kullaniciAdi AND sifre = @sifre";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);
                        command.Parameters.AddWithValue("@sifre", sifre);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Kullanıcı bilgilerini alıyoruz.
                                int kullaniciId = reader.GetInt32("kullanici_id");
                                string rol = reader.GetString("rol");
                                int ilgiliTabloId = reader.IsDBNull(reader.GetOrdinal("ilgili_tablo_id")) ? 0 : reader.GetInt32("ilgili_tablo_id");

                                // Role göre ilgili formu açıyoruz.
                                if (rol == "Yonetici")
                                {
                                    Yonetici_ekrani yoneticiForm = new Yonetici_ekrani();
                                    yoneticiForm.Show();
                                }
                                else if (rol == "Calisan")
                                {
                                    Calisan_Ekrani calisanForm = new Calisan_Ekrani();
                                    calisanForm.Show();
                                }
                                else if (rol == "Musteri")
                                {
                                    MusteriEkrani musteriForm = new MusteriEkrani(ilgiliTabloId);
                                    musteriForm.Show();
                                }

                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Kullanıcı adı veya şifre yanlış!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txt_sifre_TextChanged(object sender, EventArgs e)
        {
            // Şifre alanındaki yazıları gizlemek için PasswordChar özelliğini kullanıyoruz.
            txt_sifre.PasswordChar = '*';
        }
    }
}
