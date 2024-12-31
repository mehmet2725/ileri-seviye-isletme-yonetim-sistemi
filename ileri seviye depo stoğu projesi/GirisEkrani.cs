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

        }



        private void btn_giris_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txt_kulAd.Text.Trim();
            string sifre = txt_sifre.Text.Trim();

            if (string.IsNullOrEmpty(kullaniciAdi) || string.IsNullOrEmpty(sifre))
            {
                MessageBox.Show("Kullanıcı adı ve şifre boş bırakılamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_kulAd.Focus();
                return;
            }

            string connectionString = "Server=localhost;Database=bitirme_projesi;Uid=root;Pwd=138426;";
            string query = "SELECT kullanici_id, rol FROM kullanicilar WHERE eposta = @kullaniciAdi AND sifre = @sifre";

            try
            {
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
                                reader.Close();

                                // Çalışanlar için yetki seviyesi kontrolü
                                if (rol == "Calisan")
                                {
                                    string yetkiSeviyesiQuery = "SELECT yetki_seviyesi FROM calisanlar WHERE kullanici_id = @kullaniciId";
                                    using (MySqlCommand yetkiCmd = new MySqlCommand(yetkiSeviyesiQuery, connection))
                                    {
                                        yetkiCmd.Parameters.AddWithValue("@kullaniciId", CurrentUserId);
                                        object yetkiSeviyesiResult = yetkiCmd.ExecuteScalar();

                                        if (yetkiSeviyesiResult != null)
                                        {
                                            CurrentUserYetkiSeviyesi = Convert.ToInt32(yetkiSeviyesiResult);
                                        }
                                        else
                                        {
                                            MessageBox.Show("Yetki seviyesi alınamadı. Sistem yöneticisine başvurun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            return;
                                        }
                                    }
                                }

                                // Rol kontrolü ve ekran yönlendirme
                                if (rol == "Yonetici")
                                {
                                    new Yonetici_ekrani().Show();
                                }
                                else if (rol == "Calisan")
                                {
                                    new Calisan_Ekrani().Show();
                                }
                                else if (rol == "Musteri")
                                {
                                    new MusteriEkrani(CurrentUserId).Show();
                                }

                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Kullanıcı adı veya şifre yanlış!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txt_kulAd.Text = "";
                                txt_sifre.Text = "";
                                txt_kulAd.Focus();
                                return;
                            }
                        }
                    }
                }

                // Log kaydı
                using (MySqlConnection logConnection = new MySqlConnection(connectionString))
                {
                    logConnection.Open();
                    string logQuery = "INSERT INTO loglar (kullanici_id, islem_tarihi, tablo_adi, islem_tipi, detaylar) " +
                                      "VALUES (@kullaniciId, NOW(), NULL, 'Giriş', 'Kullanıcı başarıyla giriş yaptı.')";

                    using (MySqlCommand logCmd = new MySqlCommand(logQuery, logConnection))
                    {
                        logCmd.Parameters.AddWithValue("@kullaniciId", CurrentUserId);
                        logCmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private bool DogruKullaniciMi(string kullaniciAdi, string sifre)
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


       
    }
}
