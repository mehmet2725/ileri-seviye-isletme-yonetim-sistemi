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

        private void btnMusteriBilgi_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=bitirme_projesi;Uid=root;Pwd=138426;";
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // `kullanici_id` üzerinden `musteriler` tablosundaki bilgileri çekiyoruz
                    string query = "SELECT * FROM musteriler WHERE kullanici_id = @kullaniciId";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@kullaniciId", musteriId); // `musteriId`, giriş yapan kullanıcının ID'si

                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if (table.Rows.Count > 0) // Eğer veri dönerse DataGridView'e bağla
                        {
                            data_musteriBilgi.DataSource = table;
                        }
                        else
                        {
                            MessageBox.Show("Müşteri bilgisi bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }

                    // Log kaydı ekleme
                    string logQuery = "INSERT INTO loglar (kullanici_id, islem_tarihi, tablo_adi, islem_tipi, detaylar) " +
                                      "VALUES (@kullaniciId, NOW(), 'musteriler', 'Veri Çekme', 'Müşteri bilgileri görüntülendi.')";
                    using (MySqlCommand logCmd = new MySqlCommand(logQuery, connection))
                    {
                        logCmd.Parameters.AddWithValue("@kullaniciId", musteriId);
                        logCmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSiparisBilgi_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=bitirme_projesi;Uid=root;Pwd=138426;";
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Sipariş bilgilerini DataGridView'e doldurmak
                    string query = "SELECT * FROM siparisler WHERE musteri_id = @musteriId";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@musteriId", musteriId);

                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        data_siparisBilgi.DataSource = table; // Veriyi DataGridView'e bağla
                    }

                    // Log kaydı ekleme
                    string logQuery = "INSERT INTO loglar (kullanici_id, islem_tarihi, tablo_adi, islem_tipi, detaylar) " +
                                      "VALUES (@kullaniciId, NOW(), 'siparisler', 'Veri Çekme', 'Sipariş bilgileri görüntülendi.')";
                    using (MySqlCommand logCmd = new MySqlCommand(logQuery, connection))
                    {
                        logCmd.Parameters.AddWithValue("@kullaniciId", musteriId);
                        logCmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnGecmisSiparis_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=bitirme_projesi;Uid=root;Pwd=138426;";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Sadece tamamlanmış siparişleri çekme sorgusu
                    string query = "SELECT siparis_id, siparis_tarihi, toplam_tutar, siparis_durumu " +
                                   "FROM siparisler " +
                                   "WHERE musteri_id = @musteriId AND siparis_durumu = 'Tamamlandi'";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@musteriId", GirisEkrani.CurrentUserId);

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            // DataGridView'e veriyi bağlıyoruz
                            data_gecmisSiparis.DataSource = table;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void data_siparisBilgi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Tıklanan satırın indexini alıyoruz
                int rowIndex = e.RowIndex;

                // Eğer geçerli bir satır ise
                if (rowIndex >= 0)
                {
                    // Datagridview'den tıklanan satırın verilerini alıyoruz
                    DataGridViewRow selectedRow = data_siparisBilgi.Rows[rowIndex];
                    string siparisId = selectedRow.Cells["siparis_id"].Value.ToString();
                    string musteriId = selectedRow.Cells["musteri_id"].Value.ToString();
                    string toplamTutar = selectedRow.Cells["toplam_tutar"].Value.ToString();
                    string siparisTarihi = selectedRow.Cells["siparis_tarihi"].Value.ToString();
                    string siparisDurumu = selectedRow.Cells["siparis_durumu"].Value.ToString();

                    // Verileri MessageBox ile gösteriyoruz
                    MessageBox.Show(
                        $"Sipariş ID: {siparisId}\n" +
                        $"Müşteri ID: {musteriId}\n" +
                        $"Toplam Tutar: {toplamTutar}\n" +
                        $"Sipariş Tarihi: {siparisTarihi}\n" +
                        $"Sipariş Durumu: {siparisDurumu}",
                        "Sipariş Detayları",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void data_musteriBilgi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Tıklanan satırın indexini alıyoruz
                int rowIndex = e.RowIndex;

                // Eğer geçerli bir satır ise
                if (rowIndex >= 0)
                {
                    // Datagridview'den tıklanan satırın verilerini alıyoruz
                    DataGridViewRow selectedRow = data_musteriBilgi.Rows[rowIndex];
                    string musteriId = selectedRow.Cells["musteri_id"].Value.ToString();
                    string kullaniciId = selectedRow.Cells["kullanici_id"].Value.ToString();
                    string borcDurumu = selectedRow.Cells["borc_durumu"].Value.ToString();
                    string toplamAlacak = selectedRow.Cells["toplam_alacak"].Value.ToString();
                    string hesapDurumu = selectedRow.Cells["hesap_durumu"].Value.ToString();

                    // Verileri MessageBox ile gösteriyoruz
                    MessageBox.Show(
                        $"Müşteri ID: {musteriId}\n" +
                        $"Kullanıcı ID: {kullaniciId}\n" +
                        $"Borç Durumu: {borcDurumu}\n" +
                        $"Toplam Alacak: {toplamAlacak}\n" +
                        $"Hesap Durumu: {hesapDurumu}",
                        "Müşteri Detayları",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void data_gecmisSiparis_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Tıklanan satırın indexini alıyoruz
                int rowIndex = e.RowIndex;

                // Eğer geçerli bir satır ise
                if (rowIndex >= 0)
                {
                    // Datagridview'den tıklanan satırın verilerini alıyoruz
                    DataGridViewRow selectedRow = data_gecmisSiparis.Rows[rowIndex];
                    string siparisId = selectedRow.Cells["siparis_id"].Value.ToString();

                    string toplamTutar = selectedRow.Cells["toplam_tutar"].Value.ToString();
                    string siparisTarihi = selectedRow.Cells["siparis_tarihi"].Value.ToString();
                    string siparisDurumu = selectedRow.Cells["siparis_durumu"].Value.ToString();

                    // Verileri MessageBox ile gösteriyoruz
                    MessageBox.Show(
                        $"Sipariş ID: {siparisId}\n" +
                        $"Müşteri ID: {musteriId}\n" +
                        $"Toplam Tutar: {toplamTutar}\n" +
                        $"Sipariş Tarihi: {siparisTarihi}\n" +
                        $"Sipariş Durumu: {siparisDurumu}",
                        "Geçmiş Sipariş Detayları",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            // Güncelleme için gerekli veritabanı bağlantı bilgisi
            string connectionString = "Server=localhost;Database=bitirme_projesi;Uid=root;Pwd=138426;";

            // Kullanıcıdan alınan yeni telefon ve e-posta bilgileri
            string yeniTelefon = txt_telNo.Text.Trim();
            string yeniEposta = txt_eposta.Text.Trim();

            // Eğer alanlar boşsa kullanıcıya uyarı gösterilir
            if (string.IsNullOrEmpty(yeniTelefon) || string.IsNullOrEmpty(yeniEposta))
            {
                MessageBox.Show("Lütfen hem telefon hem de e-posta bilgilerini doldurun!", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Telefon numarası uzunluk kontrolü
            if (yeniTelefon.Length != 11)
            {
                MessageBox.Show("Telefon numarası 11 haneli olmalıdır!", "Hatalı Telefon Numarası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Telefon ve e-posta onayı için tek bir onay mesajı
            var sonuc = MessageBox.Show("Telefon numaranızı ve e-posta adresinizi değiştirmek istediğinizden emin misiniz?",
                                        "Bilgi Güncelleme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sonuc == DialogResult.No)
            {
                return; // Kullanıcı onaylamazsa işlemi sonlandır
            }

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Önce `musteriler` tablosunu güncelle
                    string updateMusterilerQuery = "UPDATE musteriler SET telefon = @yeniTelefon, eposta = @yeniEposta WHERE kullanici_id = @kullaniciId";
                    using (MySqlCommand cmdMusteriler = new MySqlCommand(updateMusterilerQuery, connection))
                    {
                        cmdMusteriler.Parameters.AddWithValue("@yeniTelefon", yeniTelefon);
                        cmdMusteriler.Parameters.AddWithValue("@yeniEposta", yeniEposta);
                        cmdMusteriler.Parameters.AddWithValue("@kullaniciId", musteriId); // Kullanıcı ID'si `kullanici_id` ile eşleşiyor
                        cmdMusteriler.ExecuteNonQuery();
                    }

                    // Ardından `kullanicilar` tablosunu güncelle
                    string updateKullanicilarQuery = "UPDATE kullanicilar SET eposta = @yeniEposta WHERE kullanici_id = @kullaniciId";
                    using (MySqlCommand cmdKullanicilar = new MySqlCommand(updateKullanicilarQuery, connection))
                    {
                        cmdKullanicilar.Parameters.AddWithValue("@yeniEposta", yeniEposta);
                        cmdKullanicilar.Parameters.AddWithValue("@kullaniciId", musteriId); // Aynı ID ile eşleştiriyoruz
                        cmdKullanicilar.ExecuteNonQuery();
                    }

                    // Log kaydı ekleme (müşteriye gösterilmeyecek)
                    string logQuery = "INSERT INTO loglar (kullanici_id, islem_tarihi, tablo_adi, islem_tipi, detaylar) " +
                                      "VALUES (@kullaniciId, NOW(), 'musteriler ve kullanicilar', 'Güncelleme', 'Telefon ve e-posta bilgileri güncellendi.')";
                    using (MySqlCommand logCmd = new MySqlCommand(logQuery, connection))
                    {
                        logCmd.Parameters.AddWithValue("@kullaniciId", musteriId);
                        logCmd.ExecuteNonQuery();
                    }

                    // Kullanıcıya başarı mesajı gösteriliyor
                    MessageBox.Show($"İletişim bilgileri başarıyla güncellendi!\nYeni Telefon: {yeniTelefon}\nYeni E-posta: {yeniEposta}", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Telefon girişini sınırlandırma (KeyPress Event)
        private void txt_telNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Sadece rakam girişine izin ver
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
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
                    MessageBox.Show($"Müşteri ID Doğrulama Sonucu: {count}"); // Burada sonucu yazdır
                    return count > 0;
                }
            }
        }

        private void btn_gonder_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=bitirme_projesi;Uid=root;Pwd=138426;";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Kullanıcı ID'si ile müşteri var mı kontrol et
                    string musteriKontrolQuery = "SELECT COUNT(*) FROM musteriler WHERE kullanici_id = @kullaniciId";
                    using (MySqlCommand musteriKontrolCmd = new MySqlCommand(musteriKontrolQuery, connection))
                    {
                        musteriKontrolCmd.Parameters.AddWithValue("@kullaniciId", musteriId); // Burada kullanici_id kontrol ediliyor.
                        int musteriSayisi = Convert.ToInt32(musteriKontrolCmd.ExecuteScalar());

                        if (musteriSayisi == 0)
                        {
                            MessageBox.Show("Bu müşteri kaydı mevcut değil!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // Feedback verisini ekleme sorgusu
                    string query = "INSERT INTO feedback (musteri_id, geri_bildirim, tarih) " +
                                   "VALUES ((SELECT musteri_id FROM musteriler WHERE kullanici_id = @kullaniciId), @feedback, NOW())";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@kullaniciId", musteriId); // Kullanıcı ID'si üzerinden işlem yapıyoruz.
                        cmd.Parameters.AddWithValue("@feedback", rtb_feedback.Text); // Feedback içeriği

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Geri bildiriminiz için teşekkür ederiz!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            rtb_feedback.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Geri bildirim kaydedilemedi. Lütfen tekrar deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            GirisEkrani geri = new GirisEkrani();
            geri.Show();
            this.Close();
        }
    }
}