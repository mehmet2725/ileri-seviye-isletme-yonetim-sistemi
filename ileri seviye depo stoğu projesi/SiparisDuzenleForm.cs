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
    public partial class SiparisDuzenleForm : Form
    {
        private int siparisId; // Sipariş ID değişkeni

        public SiparisDuzenleForm(int siparisId)
        {
            InitializeComponent();
            this.siparisId = siparisId; // Değeri atanıyor
            MessageBox.Show($"Sipariş ID: {this.siparisId}", "Debug");
        }

        private void SiparisDuzenleForm_Load(object sender, EventArgs e)
        {
            // ComboBox'a durumları ekle
            cmbSiparisDurumu.Items.AddRange(new[] { "Hazirlaniyor", "Tamamlandi", "Iptal" });

            // Sipariş bilgilerini yükle
            LoadSiparisDetails(siparisId);
        }

        private void LoadSiparisDetails(int siparisId)
        {
            string connectionString = "Server=localhost;Database=bitirme_projesi;Uid=root;Pwd=138426;";
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT musteri_id, toplam_tutar, siparis_durumu FROM siparisler WHERE siparis_id = @siparisId";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@siparisId", siparisId);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtMusteriId.Text = reader["musteri_id"].ToString();
                                txtToplamTutar.Text = reader["toplam_tutar"].ToString();
                                cmbSiparisDurumu.SelectedItem = reader["siparis_durumu"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Sipariş bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                this.Close();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                    // Decimal doğrulama ve dönüştürme
                    if (!decimal.TryParse(txtToplamTutar.Text.Replace(",", "."), System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out decimal toplamTutar))
                    {
                        MessageBox.Show("Toplam Tutar geçerli bir sayı değil.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    string query = "UPDATE siparisler SET musteri_id = @musteriId, toplam_tutar = @toplamTutar, siparis_durumu = @siparisDurumu WHERE siparis_id = @siparisId";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@musteriId", txtMusteriId.Text.Trim());
                        cmd.Parameters.AddWithValue("@toplamTutar", toplamTutar); // Decimal olarak ekleniyor
                        cmd.Parameters.AddWithValue("@siparisDurumu", cmbSiparisDurumu.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@siparisId", siparisId);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            // Log ekleme
                            string logQuery = "INSERT INTO loglar (kullanici_id, islem_tipi, detaylar, islem_tarihi) " +
                                              "VALUES (@kullaniciId, 'Düzenleme', @detaylar, NOW())";
                            using (MySqlCommand logCmd = new MySqlCommand(logQuery, connection))
                            {
                                logCmd.Parameters.AddWithValue("@kullaniciId", GirisEkrani.CurrentUserId);
                                logCmd.Parameters.AddWithValue("@detaylar", $"Sipariş {siparisId} düzenlendi.");
                                logCmd.ExecuteNonQuery();
                            }

                            MessageBox.Show("Sipariş başarıyla güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Sipariş güncellenemedi. Lütfen tekrar deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close(); // Formu kapat
        }
    }
}
