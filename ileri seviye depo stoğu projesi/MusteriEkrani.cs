using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ileri_seviye_depo_stoğu_projesi
{
    public partial class MusteriEkrani : Form
    {
        private int musteriId; // Giriş ekranından gelen ilgili tablo ID'si

        public MusteriEkrani(int ilgiliTabloId)
        {
            InitializeComponent();
            musteriId = ilgiliTabloId; // ID'yi değişkene atıyoruz
        }

        private void btn_musteriVeri_Click(object sender, EventArgs e)
        {
            // Veritabanından Müşteri Bilgilerini çekiyoruz
            string connectionString = "Server=localhost;Database=bitirme_projesi;Uid=root;Pwd=138426;";
            string query = "SELECT musteri_id, borc_durumu, toplam_alacak, hesap_durumu, telefon, eposta, adres, kayit_tarihi FROM musteriler WHERE musteri_id = @musteriId";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@musteriId", musteriId);

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            DataTable table = new DataTable();
                            adapter.Fill(table);
                            data_musteriBilgi.DataSource = table; // DataGridView'e bağlama
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message);
                }
            }
        }

        private void btn_siparisVeri_Click(object sender, EventArgs e)
        {
            // Veritabanından Sipariş Bilgilerini çekiyoruz
            string connectionString = "Server=localhost;Database=bitirme_projesi;Uid=root;Pwd=138426;";
            string query = @"SELECT s.siparis_id, s.siparis_tarihi, s.toplam_tutar, s.siparis_durumu, su.urun_id, su.miktar, su.birim_fiyat, su.toplam_fiyat 
                             FROM siparisler s 
                             JOIN siparis_urunler su ON s.siparis_id = su.siparis_id 
                             WHERE s.musteri_id = @musteriId";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@musteriId", musteriId);

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            DataTable table = new DataTable();
                            adapter.Fill(table);
                            data_siparisBilgi.DataSource = table; // DataGridView'e bağlama
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message);
                }
            }
        }

        private void MusteriEkrani_Load(object sender, EventArgs e)
        {
            // Form yüklenirken herhangi bir işlem eklenebilir
        }
    }
}
