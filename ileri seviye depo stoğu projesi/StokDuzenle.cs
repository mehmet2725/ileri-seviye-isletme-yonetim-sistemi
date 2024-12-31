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
    public partial class StokDuzenle : Form
    {
        private string urunId;
        private string urunAdi;
        private string stokMiktari;
        private string fiyat;
        private string sonGuncelleme;

        private void StokDuzenle_Load(object sender, EventArgs e)
        {
            InitializeComponent();
            this.urunId = urunId;
            this.urunAdi = urunAdi;
            this.stokMiktari = stokMiktari;
            this.fiyat = fiyat;
            this.sonGuncelleme = sonGuncelleme;

            // Form yüklenirken değerleri doldur
            lblUrunId.Text = urunId;
            txtUrunAdi.Text = urunAdi;
            txtStokMiktari.Text = stokMiktari;
            txtFiyat.Text = fiyat;

            // Eğer son güncelleme bilgisi varsa label'a yaz, yoksa mevcut tarihi koy
            lblSonGuncelleme.Text = !string.IsNullOrEmpty(sonGuncelleme)
                ? $"Son Güncelleme: {sonGuncelleme}"
                : $"Son Güncelleme: {DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss")}";
        }

        private void LoadUrunDetails(string urunId)
        {
            string connectionString = "Server=localhost;Database=bitirme_projesi;Uid=root;Pwd=138426;";
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT urun_adi, stok_miktari, fiyat FROM urunler WHERE urun_id = @urunId";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@urunId", urunId);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtUrunAdi.Text = reader["urun_adi"].ToString();
                                txtStokMiktari.Text = reader["stok_miktari"].ToString();
                                txtFiyat.Text = reader["fiyat"].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ürün bilgileri yüklenemedi: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public StokDuzenle(string urunId, string urunAdi, string stokMiktari, string fiyat, string sonGuncelleme)
        {
            InitializeComponent();

            // Parametreleri formdaki alanlara doldur
            lblUrunId.Text = urunId;
            txtUrunAdi.Text = urunAdi;
            txtStokMiktari.Text = stokMiktari;
            txtFiyat.Text = fiyat;
            lblSonGuncelleme.Text = string.IsNullOrEmpty(sonGuncelleme) ? "Henüz güncellenmemiş" : sonGuncelleme;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=bitirme_projesi;Uid=root;Pwd=138426;";
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    if (!string.IsNullOrEmpty(lblUrunId.Text)) // Düzenleme işlemi
                    {
                        string updateQuery = "UPDATE urunler SET urun_adi = @urunAdi, stok_miktari = @stokMiktari, fiyat = @fiyat, guncellenme_tarihi = NOW() WHERE urun_id = @urunId";
                        using (MySqlCommand cmd = new MySqlCommand(updateQuery, connection))
                        {
                            cmd.Parameters.AddWithValue("@urunAdi", txtUrunAdi.Text);
                            cmd.Parameters.AddWithValue("@stokMiktari", txtStokMiktari.Text);
                            cmd.Parameters.AddWithValue("@fiyat", txtFiyat.Text);
                            cmd.Parameters.AddWithValue("@urunId", lblUrunId.Text);
                            cmd.ExecuteNonQuery();
                        }

                        Calisan_Ekrani.LogIslem(GirisEkrani.CurrentUserId, "Güncelleme", $"Ürün Güncellendi: {txtUrunAdi.Text}");
                        MessageBox.Show("Ürün başarıyla güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else // Yeni ekleme işlemi
                    {
                        string insertQuery = "INSERT INTO urunler (urun_adi, stok_miktari, fiyat, eklenme_tarihi) VALUES (@urunAdi, @stokMiktari, @fiyat, NOW())";
                        using (MySqlCommand cmd = new MySqlCommand(insertQuery, connection))
                        {
                            cmd.Parameters.AddWithValue("@urunAdi", txtUrunAdi.Text);
                            cmd.Parameters.AddWithValue("@stokMiktari", txtStokMiktari.Text);
                            cmd.Parameters.AddWithValue("@fiyat", txtFiyat.Text);
                            cmd.ExecuteNonQuery();
                        }

                        Calisan_Ekrani.LogIslem(GirisEkrani.CurrentUserId, "Ekleme", $"Yeni Ürün Eklendi: {txtUrunAdi.Text}");
                        MessageBox.Show("Yeni ürün başarıyla eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
