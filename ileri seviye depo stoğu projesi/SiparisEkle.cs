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
    public partial class SiparisEkle : Form
    {
        public SiparisEkle()
        {
            InitializeComponent();
        }
        private void SiparisEkle_Load(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=bitirme_projesi;Uid=root;Pwd=138426;";
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Müşteri bilgilerini ComboBox'a çek
                    string query = "SELECT kullanici_id, ad_soyad FROM kullanicilar WHERE rol = 'Musteri'";
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        if (dt.Rows.Count > 0) // Eğer müşteri bilgileri varsa ComboBox'u doldur
                        {
                            cmbMusteriSecim.DataSource = dt;
                            cmbMusteriSecim.DisplayMember = "ad_soyad";
                            cmbMusteriSecim.ValueMember = "kullanici_id";
                        }
                        else
                        {
                            MessageBox.Show("Müşteri bilgileri bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    // Ürün bilgilerini ComboBox'a çek
                    query = "SELECT urun_id, urun_adi FROM urunler";
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        if (dt.Rows.Count > 0) // Eğer ürün bilgileri varsa ComboBox'u doldur
                        {
                            cmbUrunSecim.DataSource = dt;
                            cmbUrunSecim.DisplayMember = "urun_adi";
                            cmbUrunSecim.ValueMember = "urun_id";
                        }
                        else
                        {
                            MessageBox.Show("Ürün bilgileri bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    // Sipariş Durumu Seçeneklerini Ekle
                    cmbSiparisDurumu.Items.AddRange(new string[] { "Hazirlaniyor", "Tamamlandi", "Iptal" });
                    cmbSiparisDurumu.SelectedIndex = 0; // Varsayılan olarak "Hazırlanıyor" seçili olsun
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void numSiparisMiktar_ValueChanged(object sender, EventArgs e)
        {
            HesaplaToplamTutar();
        }

        private void txtUrunFiyat_TextChanged(object sender, EventArgs e)
        {
            HesaplaToplamTutar();
        }

        private void HesaplaToplamTutar()
        {
            if (decimal.TryParse(txtUrunFiyat.Text, out decimal urunFiyat) && numSiparisMiktar.Value > 0)
            {
                decimal toplamTutar = urunFiyat * numSiparisMiktar.Value;
                txtToplamTutar.Text = toplamTutar.ToString("N2"); // Formatlı bir şekilde göster
            }
            else
            {
                txtToplamTutar.Text = "0,00";
            }
        }

        private bool IsValidMusteriId(int musteriId)
        {
            string connectionString = "Server=localhost;Database=bitirme_projesi;Uid=root;Pwd=138426;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM musteriler WHERE musteri_id = @musteriId";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@musteriId", musteriId);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0; // Müşteri mevcutsa true döner
                }
            }
        }

        private void btnSiparisEkle_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=bitirme_projesi;Uid=root;Pwd=138426;";
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Sipariş bilgilerini al
                    if (cmbMusteriSecim.SelectedValue == null || cmbMusteriSecim.SelectedValue.ToString() == "0")
                    {
                        MessageBox.Show("Lütfen geçerli bir müşteri seçin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    int musteriId = Convert.ToInt32(cmbMusteriSecim.SelectedValue);

                    if (cmbUrunSecim.SelectedValue == null || cmbUrunSecim.SelectedValue.ToString() == "0")
                    {
                        MessageBox.Show("Lütfen geçerli bir ürün seçin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    int urunId = Convert.ToInt32(cmbUrunSecim.SelectedValue);

                    int miktar = Convert.ToInt32(numSiparisMiktar.Value);
                    if (miktar <= 0)
                    {
                        MessageBox.Show("Lütfen geçerli bir miktar girin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    decimal fiyat = 0;
                    if (!decimal.TryParse(txtUrunFiyat.Text, out fiyat) || fiyat <= 0)
                    {
                        MessageBox.Show("Lütfen geçerli bir fiyat girin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    decimal toplamTutar = fiyat * miktar;

                    // Stok kontrolü
                    string stokQuery = "SELECT stok_miktari FROM urunler WHERE urun_id = @urunId";
                    using (MySqlCommand stokCmd = new MySqlCommand(stokQuery, connection))
                    {
                        stokCmd.Parameters.AddWithValue("@urunId", urunId);
                        int stokMiktari = Convert.ToInt32(stokCmd.ExecuteScalar());

                        if (stokMiktari < miktar)
                        {
                            MessageBox.Show("Stok miktarı yetersiz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // Sipariş ekleme
                    string siparisQuery = "INSERT INTO siparisler (musteri_id, toplam_tutar, siparis_durumu) VALUES (@musteriId, @toplamTutar, 'Hazirlaniyor')";
                    using (MySqlCommand siparisCmd = new MySqlCommand(siparisQuery, connection))
                    {
                        siparisCmd.Parameters.AddWithValue("@musteriId", musteriId);
                        siparisCmd.Parameters.AddWithValue("@toplamTutar", toplamTutar);
                        siparisCmd.ExecuteNonQuery();
                    }

                    // Stok güncelleme
                    string stokUpdateQuery = "UPDATE urunler SET stok_miktari = stok_miktari - @miktar WHERE urun_id = @urunId";
                    using (MySqlCommand stokUpdateCmd = new MySqlCommand(stokUpdateQuery, connection))
                    {
                        stokUpdateCmd.Parameters.AddWithValue("@miktar", miktar);
                        stokUpdateCmd.Parameters.AddWithValue("@urunId", urunId);
                        stokUpdateCmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Sipariş başarıyla eklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbUrunSecim_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=bitirme_projesi;Uid=root;Pwd=138426;";
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT stok_miktari, fiyat FROM urunler WHERE urun_id = @urunId";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@urunId", cmbUrunSecim.SelectedValue);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtStokMiktar.Text = reader["stok_miktari"].ToString();
                                txtUrunFiyat.Text = reader["fiyat"].ToString();
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

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_hesapla_Click(object sender, EventArgs e)
        {
            HesaplaToplamTutar();
        }
    }
}
