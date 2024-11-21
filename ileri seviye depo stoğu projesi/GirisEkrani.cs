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

            // MySQL bağlantı dizesi
            string connectionString = "Server=localhost;Database=bitirme_projesi;Uid=root;Pwd=138426;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    // Kullanıcı adı ve şifreye göre ilgili_id ve rol bilgilerini sorgulama
                    string query = "SELECT ilgili_id, rol FROM Kullanicilar WHERE kullanici_adi = @kullaniciAdi AND sifre = @sifre";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);
                    command.Parameters.AddWithValue("@sifre", sifre);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Kullanıcı bilgileri bulundu.
                            int ilgiliId = reader.GetInt32("ilgili_id");
                            string rol = reader.GetString("rol");

                            // ID aralıklarına göre yönlendirme
                            if (ilgiliId >= 1 && ilgiliId <= 1000 && rol == "Yonetici")
                            {
                                Yonetici_ekrani yoneticiForm = new Yonetici_ekrani();
                                yoneticiForm.Show();
                                this.Hide();
                            }
                            else if (ilgiliId >= 1001 && ilgiliId <= 5000 && rol == "Calisan")
                            {
                                Calisan_Ekrani calisanForm = new Calisan_Ekrani();
                                calisanForm.Show();
                                this.Hide();
                            }
                            else if (ilgiliId >= 5001 && rol == "Musteri")
                            {
                                MusteriEkrani musteriForm = new MusteriEkrani();
                                musteriForm.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Geçersiz kullanıcı bilgileri!");
                            }
                        }
                        else
                        {
                            // Kullanıcı adı veya şifre hatalı
                            MessageBox.Show("Kullanıcı adı veya şifre yanlış!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Hata mesajı
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }
    }
}
