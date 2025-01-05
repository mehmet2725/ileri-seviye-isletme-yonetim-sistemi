using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace ileri_seviye_depo_stoğu_projesi
{
    public partial class CalisanDuzenle : Form
    {
        private string calisanId;

        public CalisanDuzenle(string calisanId = "")
        {
            InitializeComponent();
            this.calisanId = calisanId;

            if (!string.IsNullOrEmpty(calisanId))
            {
                LoadCalisanDetails(); // Çalışan bilgilerini yükle
            }
        }

        private void CalisanDuzenle_Load(object sender, EventArgs e)
        {
            // Çalışma durumu combobox'ına veri ekle
            cmbDurum.Items.Add("Aktif");
            cmbDurum.Items.Add("Pasif");

            // İzin durumu combobox'ına veri ekle
            cmbIzinDurumu.Items.Add("Evet");
            cmbIzinDurumu.Items.Add("Hayır");

            // Eğer bir çalışan ID'si varsa bilgileri yükle
            if (!string.IsNullOrEmpty(calisanId))
            {
                LoadCalisanDetails();
            }
        }

        private void LoadCalisanDetails()
        {
            string connectionString = "Server=localhost;Database=bitirme_projesi;Uid=root;Pwd=138426;";
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"
                SELECT 
                    kullanicilar.ad_soyad,
                    kullanicilar.eposta,
                    calisanlar.gorev,
                    calisanlar.vardiya_baslangic_zamani,
                    calisanlar.vardiya_bitis_zamani,
                    calisanlar.izin_durumu,
                    calisanlar.calisma_durumu,
                    calisanlar.yetki_seviyesi
                FROM calisanlar
                INNER JOIN kullanicilar ON calisanlar.kullanici_id = kullanicilar.kullanici_id
                WHERE calisanlar.calisan_id = @calisanId";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@calisanId", calisanId);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtAdSoyad.Text = reader["ad_soyad"].ToString();
                                txtEposta.Text = reader["eposta"].ToString();
                                txtGorev.Text = reader["gorev"].ToString();
                                txtBaslangicVardiya.Text = reader["vardiya_baslangic_zamani"].ToString();
                                txtBitisVardiya.Text = reader["vardiya_bitis_zamani"].ToString();
                                cmbIzinDurumu.SelectedItem = reader["izin_durumu"].ToString() == "1" ? "Evet" : "Hayır";
                                cmbDurum.SelectedItem = reader["calisma_durumu"].ToString();
                                txtYetkiSeviyesi.Text = reader["yetki_seviyesi"].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Çalışan bilgileri yüklenirken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LogIslem(int kullaniciId, string islemTipi, string detaylar)
        {
            string connectionString = "Server=localhost;Database=bitirme_projesi;Uid=root;Pwd=138426;";
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO loglar (kullanici_id, islem_tarihi, tablo_adi, islem_tipi, detaylar) " +
                                   "VALUES (@kullaniciId, NOW(), 'calisanlar', @islemTipi, @detaylar)";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@kullaniciId", kullaniciId);
                        cmd.Parameters.AddWithValue("@islemTipi", islemTipi);
                        cmd.Parameters.AddWithValue("@detaylar", detaylar);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Log kaydedilemedi: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=bitirme_projesi;Uid=root;Pwd=138426;";
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    if (!string.IsNullOrEmpty(calisanId))
                    {
                        // Çalışanı güncelle
                        string updateQuery = @"
                    UPDATE calisanlar
                    INNER JOIN kullanicilar ON calisanlar.kullanici_id = kullanicilar.kullanici_id
                    SET 
                        kullanicilar.ad_soyad = @adSoyad,
                        kullanicilar.eposta = @eposta,
                        calisanlar.gorev = @gorev,
                        calisanlar.vardiya_baslangic_zamani = @baslangic,
                        calisanlar.vardiya_bitis_zamani = @bitis,
                        calisanlar.izin_durumu = @izin,
                        calisanlar.calisma_durumu = @durum,
                        calisanlar.yetki_seviyesi = @yetki
                    WHERE calisanlar.calisan_id = @calisanId";

                        using (MySqlCommand cmd = new MySqlCommand(updateQuery, connection))
                        {
                            cmd.Parameters.AddWithValue("@adSoyad", txtAdSoyad.Text);
                            cmd.Parameters.AddWithValue("@eposta", txtEposta.Text);
                            cmd.Parameters.AddWithValue("@gorev", txtGorev.Text);
                            cmd.Parameters.AddWithValue("@baslangic", txtBaslangicVardiya.Text);
                            cmd.Parameters.AddWithValue("@bitis", txtBitisVardiya.Text);
                            cmd.Parameters.AddWithValue("@izin", cmbIzinDurumu.SelectedItem.ToString() == "Evet" ? 1 : 0);
                            cmd.Parameters.AddWithValue("@durum", cmbDurum.SelectedItem.ToString());
                            cmd.Parameters.AddWithValue("@yetki", txtYetkiSeviyesi.Text);
                            cmd.Parameters.AddWithValue("@calisanId", calisanId);

                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Çalışan bilgileri başarıyla güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            // Log: İptal
            LogIslem(GirisEkrani.CurrentUserId, "İptal", "Çalışan düzenleme işlemi iptal edildi.");
            this.Close(); // Formu kapat
        }

        
    }
}
