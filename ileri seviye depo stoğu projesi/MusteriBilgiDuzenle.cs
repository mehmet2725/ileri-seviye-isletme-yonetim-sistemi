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
    public partial class MusteriBilgiDuzenle : Form
    {
        private int musteriId; // Müşteri ID değişkeni
        public MusteriBilgiDuzenle(int musteriId)
        {
            InitializeComponent();
            this.musteriId = musteriId;

            // Müşteri bilgilerini yükle
            LoadMusteriDetails();
        }

        private void MusteriBilgiDuzenle_Load(object sender, EventArgs e)
        {

        }

        private void LoadMusteriDetails()
        {
            string connectionString = "Server=localhost;Database=bitirme_projesi;Uid=root;Pwd=138426;";
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"
                SELECT 
                    m.borc_durumu, 
                    m.toplam_alacak, 
                    m.hesap_durumu, 
                    m.telefon, 
                    m.eposta, 
                    m.adres, 
                    k.ad_soyad 
                FROM musteriler m
                INNER JOIN kullanicilar k ON m.kullanici_id = k.kullanici_id
                WHERE m.musteri_id = @musteriId";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@musteriId", musteriId);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtAdSoyad.Text = reader["ad_soyad"].ToString();
                                txtBorcDurumu.Text = reader["borc_durumu"].ToString();
                                txtToplamAlacak.Text = reader["toplam_alacak"].ToString();
                                chkHesapDurumu.Checked = Convert.ToBoolean(reader["hesap_durumu"]);
                                txtTelefon.Text = reader["telefon"].ToString();
                                txtEposta.Text = reader["eposta"].ToString();
                                txtAdres.Text = reader["adres"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Müşteri bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

                    // Parametreleri hazırla
                    decimal borcDurumu = 0, toplamAlacak = 0;
                    int hesapDurumu = chkHesapDurumu.Checked ? 1 : 0; // Checkbox değerini 1 veya 0 olarak al
                    string telefon = txtTelefon.Text.Trim();
                    string eposta = txtEposta.Text.Trim();
                    string adres = txtAdres.Text.Trim();

                    // Decimal değerleri kontrol et ve dönüştür
                    if (!string.IsNullOrEmpty(txtBorcDurumu.Text))
                    {
                        if (!decimal.TryParse(txtBorcDurumu.Text, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out borcDurumu))
                        {
                            MessageBox.Show("Borc durumu geçerli bir sayı değil.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    if (!string.IsNullOrEmpty(txtToplamAlacak.Text))
                    {
                        if (!decimal.TryParse(txtToplamAlacak.Text, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out toplamAlacak))
                        {
                            MessageBox.Show("Toplam alacak geçerli bir sayı değil.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // Güncelleme sorgusu
                    string query = @"
        UPDATE musteriler 
        SET borc_durumu = @borcDurumu, 
            toplam_alacak = @toplamAlacak, 
            hesap_durumu = @hesapDurumu, 
            telefon = @telefon, 
            eposta = @eposta, 
            adres = @adres 
        WHERE musteri_id = @musteriId";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@borcDurumu", borcDurumu);
                        cmd.Parameters.AddWithValue("@toplamAlacak", toplamAlacak);
                        cmd.Parameters.AddWithValue("@hesapDurumu", hesapDurumu);
                        cmd.Parameters.AddWithValue("@telefon", string.IsNullOrEmpty(telefon) ? DBNull.Value : (object)telefon);
                        cmd.Parameters.AddWithValue("@eposta", string.IsNullOrEmpty(eposta) ? DBNull.Value : (object)eposta);
                        cmd.Parameters.AddWithValue("@adres", string.IsNullOrEmpty(adres) ? DBNull.Value : (object)adres);
                        cmd.Parameters.AddWithValue("@musteriId", musteriId);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Müşteri bilgileri başarıyla güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Calisan_Ekrani.LogIslem(GirisEkrani.CurrentUserId, "Düzenleme", $"Müşteri bilgileri düzenlendi: Müşteri ID {musteriId}");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Müşteri bilgileri güncellenemedi. Lütfen tekrar deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
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
            this.Close();
        }
    }
}
