using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ileri_seviye_depo_stoğu_projesi
{
    public partial class Calisan_Ekrani : Form
    {
        public Calisan_Ekrani()
        {
            InitializeComponent();
        }
        public static int CurrentUserYetkiSeviyesi { get; set; }
        private void Calisan_Ekrani_Load(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=bitirme_projesi;Uid=root;Pwd=138426;";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Kullanıcının yetki seviyesini kontrol et
                    string query = "SELECT yetki_seviyesi FROM calisanlar WHERE kullanici_id = @kullaniciId";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@kullaniciId", GirisEkrani.CurrentUserId);
                        MessageBox.Show($"Çalışan Ekranı - CurrentUserId: {GirisEkrani.CurrentUserId}", "Debug");

                        object result = cmd.ExecuteScalar();
                        // Debug için türünü ve değerini kontrol et
                        MessageBox.Show($"ExecuteScalar Result: {result}, Type: {result?.GetType()}", "Debug ExecuteScalar Result");


                        if (result != null)
                        {
                            GirisEkrani.CurrentUserYetkiSeviyesi = Convert.ToInt32(result);

                            // Yetki seviyesini label'e yazdır
                            lblYetkiSeviyesi.Text = "Yetki Seviyesi: " + GirisEkrani.CurrentUserYetkiSeviyesi.ToString();

                            // Yetki seviyesine göre butonları ayarla
                            btn_calismaVeri.Enabled = true;
                            btn_SiparisBilgileri.Enabled = GirisEkrani.CurrentUserYetkiSeviyesi >= 2;
                            btn_StokBilgileri.Enabled = GirisEkrani.CurrentUserYetkiSeviyesi >= 2;
                            btn_musteriVeri.Enabled = GirisEkrani.CurrentUserYetkiSeviyesi == 3;
                        }
                        else
                        {
                            MessageBox.Show("Yetki seviyesi alınamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void btn_calismaVeri_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=bitirme_projesi;Uid=root;Pwd=138426;";
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Çalışma saatleri ve vardiya bilgilerini çekme sorgusu
                    string query = @"
                SELECT 
                    calisan_id AS 'Çalışan ID',
                    gorev AS 'Görev',
                    vardiya_baslangic_zamani AS 'Vardiya Başlangıcı',
                    vardiya_bitis_zamani AS 'Vardiya Bitişi',
                    CASE 
                        WHEN izin_durumu = 1 THEN 'Talep Edilebilir'
                        ELSE 'Edilemez'
                    END AS 'İzin Durumu',
                    calisma_durumu AS 'Çalışma Durumu'
                FROM calisanlar
                WHERE kullanici_id = @kullaniciId";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@kullaniciId", GirisEkrani.CurrentUserId);

                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        data_vardiyaSaat.DataSource = table;
                        data_vardiyaSaat.ReadOnly = true;
                        data_vardiyaSaat.AllowUserToAddRows = false;
                        data_vardiyaSaat.AllowUserToDeleteRows = false;
                        data_vardiyaSaat.AllowUserToOrderColumns = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void data_vardiyaSaat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowIndex = e.RowIndex;

                if (rowIndex >= 0)
                {
                    DataGridViewRow selectedRow = data_vardiyaSaat.Rows[rowIndex];
                    string calisanId = selectedRow.Cells["Çalışan ID"].Value?.ToString();
                    string gorev = selectedRow.Cells["Görev"].Value?.ToString();
                    string vardiyaBaslangic = selectedRow.Cells["Vardiya Başlangıcı"].Value?.ToString();
                    string vardiyaBitis = selectedRow.Cells["Vardiya Bitişi"].Value?.ToString();
                    string izinDurumu = selectedRow.Cells["İzin Durumu"].Value?.ToString();
                    string calismaDurumu = selectedRow.Cells["Çalışma Durumu"].Value?.ToString();

                    MessageBox.Show(
                        $"Çalışan ID: {calisanId}\n" +
                        $"Görev: {gorev}\n" +
                        $"Vardiya Başlangıcı: {vardiyaBaslangic}\n" +
                        $"Vardiya Bitişi: {vardiyaBitis}\n" +
                        $"İzin Durumu: {izinDurumu}\n" +
                        $"Çalışma Durumu: {calismaDurumu}",
                        "Çalışan Detayları",
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




        private void btn_SiparisBilgileri_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=bitirme_projesi;Uid=root;Pwd=138426;";
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Sipariş bilgilerini çekme sorgusu
                    string query = @"
                SELECT 
                    siparis_id AS 'Sipariş ID', 
                    musteri_id AS 'Müşteri ID', 
                    toplam_tutar AS 'Toplam Tutar', 
                    siparis_durumu AS 'Sipariş Durumu' 
                FROM siparisler";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        // DataGridView'e veriyi bağla
                        data_siparisBilgi.Columns.Clear(); // Eski sütunları temizle
                        data_siparisBilgi.DataSource = table;

                        // Onayla ve İptal Et butonları ekle
                        AddButtonColumn("Onayla", "Onayla");
                        AddButtonColumn("İptal Et", "İptal Et");

                        // Sadece 3. seviye kullanıcılar için Düzenle butonu ekle
                        if (GirisEkrani.CurrentUserYetkiSeviyesi == 3)
                        {
                            AddButtonColumn("Düzenle", "Düzenle");
                        }

                        // DataGridView ayarları
                        data_siparisBilgi.AllowUserToAddRows = false;
                        data_siparisBilgi.AllowUserToDeleteRows = false;
                        data_siparisBilgi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddButtonColumn(string name, string text)
        {
            // Eğer zaten eklenmişse tekrar ekleme
            if (data_siparisBilgi.Columns.Contains(name))
                return;

            // Yeni bir buton sütunu oluştur
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn
            {
                Name = name,
                HeaderText = text,
                Text = text,
                UseColumnTextForButtonValue = true
            };

            // DataGridView'e ekle
            data_siparisBilgi.Columns.Add(buttonColumn);
        }

        private void UpdateSiparisDurumu(string siparisId, string yeniDurum)
        {
            string connectionString = "Server=localhost;Database=bitirme_projesi;Uid=root;Pwd=138426;";
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Siparişin mevcut durumunu kontrol et
                    string checkQuery = "SELECT siparis_durumu FROM siparisler WHERE siparis_id = @siparisId";
                    using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, connection))
                    {
                        checkCmd.Parameters.AddWithValue("@siparisId", siparisId);
                        string currentStatus = checkCmd.ExecuteScalar()?.ToString();

                        // Mevcut durum kontrolleri
                        if (currentStatus == yeniDurum)
                        {
                            MessageBox.Show($"Sipariş zaten '{yeniDurum}' durumunda.", "Durum Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        else if (currentStatus == "Tamamlandi" || currentStatus == "Iptal")
                        {
                            MessageBox.Show($"Bu sipariş '{currentStatus}' durumunda ve artık değiştirilemez.", "Durum Güncelleme Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        // Güncelleme sorgusu
                        string updateQuery = "UPDATE siparisler SET siparis_durumu = @yeniDurum WHERE siparis_id = @siparisId";
                        using (MySqlCommand updateCmd = new MySqlCommand(updateQuery, connection))
                        {
                            updateCmd.Parameters.AddWithValue("@yeniDurum", yeniDurum);
                            updateCmd.Parameters.AddWithValue("@siparisId", siparisId);

                            int rowsAffected = updateCmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show($"Sipariş durumu başarıyla '{yeniDurum}' olarak güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Log kaydı ekle
                                string logQuery = "INSERT INTO loglar (kullanici_id, islem_tarihi, tablo_adi, islem_tipi, detaylar) " +
                                                  "VALUES (@kullaniciId, NOW(), 'siparisler', 'Durum Güncelleme', @detaylar)";
                                using (MySqlCommand logCmd = new MySqlCommand(logQuery, connection))
                                {
                                    logCmd.Parameters.AddWithValue("@kullaniciId", GirisEkrani.CurrentUserId);
                                    logCmd.Parameters.AddWithValue("@detaylar", $"Sipariş ID: {siparisId}, Yeni Durum: {yeniDurum}");
                                    logCmd.ExecuteNonQuery();
                                }

                            }
                            else
                            {
                                MessageBox.Show("Sipariş durumu güncellenemedi. Lütfen tekrar deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
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
                int rowIndex = e.RowIndex;

                if (rowIndex >= 0 && e.ColumnIndex >= 0) // Tıklanan hücre veri hücresiyse
                {
                    DataGridViewRow selectedRow = data_siparisBilgi.Rows[rowIndex];
                    string siparisIdStr = selectedRow.Cells["Sipariş ID"].Value?.ToString();

                    if (string.IsNullOrEmpty(siparisIdStr))
                    {
                        MessageBox.Show("Sipariş ID'si alınamadı. Lütfen tekrar deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // "Onayla" sütununa tıklandıysa
                    if (e.ColumnIndex == data_siparisBilgi.Columns["Onayla"].Index)
                    {
                        UpdateSiparisDurumu(siparisIdStr, "Tamamlandi");
                    }
                    // "İptal Et" sütununa tıklandıysa
                    else if (e.ColumnIndex == data_siparisBilgi.Columns["İptal Et"].Index)
                    {
                        UpdateSiparisDurumu(siparisIdStr, "Iptal");
                    }
                    // "Düzenle" sütununa tıklandıysa
                    else if (data_siparisBilgi.Columns[e.ColumnIndex].Name == "Düzenle" && GirisEkrani.CurrentUserYetkiSeviyesi == 3)
                    {
                        int siparisId = Convert.ToInt32(siparisIdStr); // Sipariş ID'sini int'e çevir
                        SiparisDuzenleForm duzenleForm = new SiparisDuzenleForm(siparisId); // Yeni formu oluştur
                        duzenleForm.ShowDialog(); // Formu göster
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void data_siparisBilgi_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // Sadece 3. seviyedeki kullanıcılar düzenleme yapabilir
            if (GirisEkrani.CurrentUserYetkiSeviyesi != 3)
            {
                MessageBox.Show("Bu işlemi gerçekleştirme yetkiniz yok.", "Yetki Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int rowIndex = e.RowIndex;
                int columnIndex = e.ColumnIndex;

                // Hücrelerin doğru veri içerdiğinden emin olun
                if (rowIndex >= 0 && columnIndex >= 0)
                {
                    string columnName = data_siparisBilgi.Columns[columnIndex].Name;
                    string newValue = data_siparisBilgi.Rows[rowIndex].Cells[columnIndex].Value?.ToString();
                    string siparisId = data_siparisBilgi.Rows[rowIndex].Cells["Sipariş ID"].Value?.ToString();

                    if (!string.IsNullOrEmpty(newValue) && !string.IsNullOrEmpty(siparisId))
                    {
                        // Veritabanında düzenlemeyi uygula
                        string connectionString = "Server=localhost;Database=bitirme_projesi;Uid=root;Pwd=138426;";
                        using (MySqlConnection connection = new MySqlConnection(connectionString))
                        {
                            connection.Open();

                            string updateQuery = $"UPDATE siparisler SET {columnName} = @newValue WHERE siparis_id = @siparisId";
                            using (MySqlCommand cmd = new MySqlCommand(updateQuery, connection))
                            {
                                cmd.Parameters.AddWithValue("@newValue", newValue);
                                cmd.Parameters.AddWithValue("@siparisId", siparisId);

                                int rowsAffected = cmd.ExecuteNonQuery();
                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show($"Veri başarıyla güncellendi. Kolon: {columnName}, Yeni Değer: {newValue}", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    // Loglama işlemi
                                    LogIslem(siparisId, $"'{columnName}' kolonunda değer '{newValue}' olarak güncellendi.");
                                }
                                else
                                {
                                    MessageBox.Show("Veri güncellenemedi. Lütfen tekrar deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Eksik bilgi var. Düzenleme yapılamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LogIslem(string siparisId, string durum)
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
                        string detaylar = $"Sipariş {siparisId} durumu {durum} olarak güncellendi.";
                        cmd.Parameters.AddWithValue("@kullaniciId", GirisEkrani.CurrentUserId);
                        cmd.Parameters.AddWithValue("@islemTipi", durum.Length > 50 ? durum.Substring(0, 50) : durum);
                        cmd.Parameters.AddWithValue("@detaylar", detaylar.Length > 255 ? detaylar.Substring(0, 255) : detaylar);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Loglama sırasında bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            GirisEkrani geri = new GirisEkrani();
            geri.Show();
            this.Close();
        }

        private void btn_musteriVeri_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=bitirme_projesi;Uid=root;Pwd=138426;";
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Müşteri bilgilerini çekme sorgusu
                    string query = @"
                SELECT 
                    musteri_id AS 'Müşteri ID',
                    kullanici_id AS 'Kullanıcı ID',
                    borc_durumu AS 'Borç Durumu',
                    toplam_alacak AS 'Toplam Alacak',
                    hesap_durumu AS 'Hesap Durumu',
                    telefon AS 'Telefon',
                    eposta AS 'E-posta',
                    adres AS 'Adres',
                    kayit_tarihi AS 'Kayıt Tarihi'
                FROM musteriler";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        // Veri var mı kontrol et
                        if (table.Rows.Count == 0)
                        {
                            MessageBox.Show("Hiçbir müşteri bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }

                        // DataGridView'e veriyi bağla
                        data_musteriBilgi.Columns.Clear(); // Eski sütunları temizle
                        data_musteriBilgi.DataSource = table;

                        // Düzenle butonunu ekle
                        AddButtonColumn("Düzenle", "Düzenle");

                        // DataGridView ayarları
                        data_musteriBilgi.AllowUserToAddRows = false;
                        data_musteriBilgi.AllowUserToDeleteRows = false;
                        data_musteriBilgi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
