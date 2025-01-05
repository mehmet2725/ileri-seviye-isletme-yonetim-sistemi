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
        public static int CurrentUserYetkiSeviyesi { get; set; }

        public GirisEkrani()
        {
            InitializeComponent();
        }

        private void GirisEkrani_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btn_giris; // Enter tuşu 'btnGiris' butonunu tetikler.
            MessageBox.Show($"CurrentUserId: {CurrentUserId}", "Debug");




        }

        /* private void KullaniciGiris(string kullaniciAdi, string sifre)
         {
             string connectionString = "Server=localhost;Database=bitirme_projesi;Uid=root;Pwd=138426;";
             string query = "SELECT yetki_seviyesi FROM kullanicilar WHERE eposta = @eposta AND sifre = @sifre";

             try
             {
                 using (MySqlConnection connection = new MySqlConnection(connectionString))
                 {
                     connection.Open();
                     MySqlCommand cmd = new MySqlCommand(query, connection);
                     cmd.Parameters.AddWithValue("@eposta", kullaniciAdi);
                     cmd.Parameters.AddWithValue("@sifre", sifre);

                     object result = cmd.ExecuteScalar();
                     if (result != null && result != DBNull.Value)
                     {
                         int yetkiSeviyesi = Convert.ToInt32(result);
                         // Yetki seviyesine göre giriş işlemi
                         if (yetkiSeviyesi == 1)
                         {
                             // Çalışan girişine devam et
                             MessageBox.Show("Çalışan olarak giriş yapıldı.");
                             // Çalışan ekranına yönlendir
                         }
                         else if (yetkiSeviyesi == 2)
                         {
                             // Yönetici girişine yönlendir
                             MessageBox.Show("Yönetici olarak giriş yapıldı.");
                             // Yönetici ekranına yönlendir
                         }
                         else
                         {
                             MessageBox.Show("Geçersiz yetki seviyesi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                         }
                     }
                     else
                     {
                         MessageBox.Show("Kullanıcı adı veya şifre yanlış.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                     }
                 }
             }
             catch (Exception ex)
             {
                 MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
         }*/


        private void btn_giris_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txt_kulAd.Text.Trim();
            string sifre = txt_sifre.Text.Trim();

            string connectionString = "Server=localhost;Database=bitirme_projesi;Uid=root;Pwd=138426;";
            string query = "SELECT kullanici_id, rol FROM kullanicilar WHERE eposta = @kullaniciAdi AND sifre = @sifre";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);
                    command.Parameters.AddWithValue("@sifre", sifre);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            CurrentUserId = reader.GetInt32("kullanici_id");
                            string rol = reader.GetString("rol");

                            // Burada sadece kullanıcının rolüne göre yönlendirme yapıyoruz
                            if (rol == "Yonetici")
                            {
                                new Yonetici_ekrani().Show();
                            }
                            else if (rol == "Calisan")
                            {
                                new Calisan_Ekrani(CurrentUserId).Show(); // CurrentUserId'yi parametre olarak gönderiyoruz
                            }
                            else if (rol == "Musteri")
                            {
                                new MusteriEkrani(CurrentUserId).Show();
                            }

                            this.Hide(); // Giriş ekranını gizliyoruz
                        }
                        else
                        {
                            MessageBox.Show("Kullanıcı adı veya şifre yanlış!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
        

        public static void LogIslem(int kullaniciId, string islemTipi, string detaylar)
        {
            string connectionString = "Server=localhost;Database=bitirme_projesi;Uid=root;Pwd=138426;";
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO loglar (kullanici_id, islem_tipi, detaylar, islem_tarihi) VALUES (@kullaniciId, @islemTipi, @detaylar, NOW())";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@kullaniciId", kullaniciId);
                        cmd.Parameters.AddWithValue("@islemTipi", islemTipi.Length > 100 ? islemTipi.Substring(0, 100) : islemTipi);  // 100 karakterden fazla olmayacak
                        cmd.Parameters.AddWithValue("@detaylar", detaylar.Length > 255 ? detaylar.Substring(0, 255) : detaylar);  // 255 karakterden fazla olmayacak
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Loglama sırasında bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void txt_sifre_TextChanged(object sender, EventArgs e)
        {
            txt_sifre.PasswordChar = '*';
        }

        private void chk_sifreGoster_CheckedChanged(object sender, EventArgs e)
        {
            txt_sifre.PasswordChar = chk_sifreGoster.Checked ? '\0' : '*';
        }

       /* private bool DogruKullaniciMi(string kullaniciAdi, string sifre)
        {
            bool sonuc = false;

            // MySQL bağlantısını kullan
            string connectionString = "Server=localhost;Database=proje_db;Uid=root;Pwd=138426;";
            string query = "SELECT COUNT(*) FROM kullanicilar WHERE email = @kullaniciAdi AND sifre = @sifre";

            try
            {
                using (MySqlConnection baglanti = new MySqlConnection(connectionString))
                {
                    baglanti.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, baglanti))
                    {
                        cmd.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);
                        cmd.Parameters.AddWithValue("@sifre", sifre);

                        int result = Convert.ToInt32(cmd.ExecuteScalar());
                        sonuc = result > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }

            return sonuc;
        }

        */
       
    }
}
