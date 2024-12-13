using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ileri_seviye_depo_stoğu_projesi
{
    public partial class GirisEkrani : Form
    {
        // Giriş yapan kullanıcının ID'sini saklamak için static bir özellik.
        public static int CurrentUserId { get; set; }

        public GirisEkrani()
        {
            InitializeComponent();
        }

        private void GirisEkrani_Load(object sender, EventArgs e)
        {
            // Form yüklendiğinde yapılacak işlemler (şimdilik boş bırakıldı).
            // Örneğin: Varsayılan metin kutusu değerlerini ayarlamak veya UI özelleştirmeleri yapmak için kullanılabilir.
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            // Kullanıcı giriş işlemi için gereken bilgileri alıyoruz.
            string kullaniciAdi = txt_kulAd.Text; // Kullanıcı adı veya e-posta bilgisi.
            string sifre = txt_sifre.Text;        // Kullanıcının giriş için girdiği şifre.

            // Veritabanı bağlantı bilgileri (sunucu, veritabanı adı, kullanıcı adı ve şifre).
            string connectionString = "Server=localhost;Database=bitirme_projesi;Uid=root;Pwd=138426;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    // Veritabanı bağlantısını açıyoruz.
                    connection.Open();

                    // Kullanıcı giriş bilgilerini sorgulamak için SQL sorgusu oluşturuyoruz.
                    string query = "SELECT kullanici_id, rol, ilgili_tablo_id FROM kullanicilar WHERE eposta = @kullaniciAdi AND sifre = @sifre";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // SQL sorgusundaki parametreleri kullanıcı giriş bilgileriyle dolduruyoruz.
                        command.Parameters.AddWithValue("@kullaniciAdi", txt_kulAd.Text);
                        command.Parameters.AddWithValue("@sifre", txt_sifre.Text);

                        // Sorguyu çalıştırıyoruz ve sonuçları okumak için bir MySqlDataReader kullanıyoruz.
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Kullanıcı bilgilerinin başarıyla alınması durumunda aşağıdaki işlemler yapılır:
                                CurrentUserId = reader.GetInt32("kullanici_id"); // Giriş yapan kullanıcının ID'si.
                                string rol = reader.GetString("rol");            // Kullanıcının rol bilgisi.
                                int ilgiliTabloId = reader.IsDBNull(reader.GetOrdinal("ilgili_tablo_id")) ? 0 : reader.GetInt32("ilgili_tablo_id"); // İlgili tablo ID'si.

                                // Kullanıcının rolüne göre ilgili ekran/form açılıyor.
                                if (rol == "Yonetici")
                                {
                                    Yonetici_ekrani yoneticiForm = new Yonetici_ekrani(); // Yönetici ekranı oluşturuluyor.
                                    yoneticiForm.Show();
                                }
                                else if (rol == "Calisan")
                                {
                                    Calisan_Ekrani calisanForm = new Calisan_Ekrani(); // Çalışan ekranı oluşturuluyor.
                                    calisanForm.Show();
                                }
                                else if (rol == "Musteri")
                                {
                                    MusteriEkrani musteriForm = new MusteriEkrani(ilgiliTabloId); // Müşteri ekranı oluşturuluyor.
                                    musteriForm.Show();
                                }

                                // Giriş ekranı gizleniyor.
                                this.Hide();
                            }
                            else
                            {
                                // Eğer kullanıcı adı veya şifre yanlışsa hata mesajı gösteriliyor.
                                MessageBox.Show("Kullanıcı adı veya şifre yanlış!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Veritabanı bağlantısı veya sorgu sırasında bir hata oluşursa bu mesaj gösteriliyor.
                    MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txt_sifre_TextChanged(object sender, EventArgs e)
        {
            // Şifre alanındaki yazıları gizlemek için PasswordChar özelliğini kullanıyoruz.
            // Kullanıcı şifre girerken güvenliği sağlamak için '*' karakteri gösteriliyor.
            txt_sifre.PasswordChar = '*';
        }
    }
}
