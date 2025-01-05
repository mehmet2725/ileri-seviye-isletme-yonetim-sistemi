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
    public partial class Yonetici_ekrani : Form
    {
        public Yonetici_ekrani()
        {
            InitializeComponent();
        }

        private void Yonetici_ekrani_Load(object sender, EventArgs e)
        {

            cmbRol.Items.Clear();
            cmbRol.Items.Add("Yonetici");
            cmbRol.Items.Add("Calisan");
            cmbRol.Items.Add("Musteri");
            cmbRol.SelectedIndex = 0; // İlk seçenek olarak Yonetici'yi seç
        }

        private void tab_calisanYonetim_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void YoneticiLogIslem(int kullaniciId, string islemTipi, string tabloAdi, string detaylar)
        {
            string connectionString = "Server=localhost;Database=bitirme_projesi;Uid=root;Pwd=138426;";
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"
                INSERT INTO loglar (kullanici_id, islem_tarihi, tablo_adi, islem_tipi, detaylar)
                VALUES (@kullaniciId, NOW(), @tabloAdi, @islemTipi, @detaylar)";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@kullaniciId", kullaniciId);
                        cmd.Parameters.AddWithValue("@tabloAdi", tabloAdi);
                        cmd.Parameters.AddWithValue("@islemTipi", islemTipi);
                        cmd.Parameters.AddWithValue("@detaylar", detaylar);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Log kaydedilirken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btn_musteriVeri_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=bitirme_projesi;Uid=root;Pwd=138426;";
            string query = @"
        SELECT m.musteri_id AS 'Müşteri ID',
               k.ad_soyad AS 'Ad Soyad',
               m.telefon AS 'Telefon',
               m.eposta AS 'E-Posta',
               m.adres AS 'Adres',
               m.borc_durumu AS 'Borç Durumu',
               m.toplam_alacak AS 'Toplam Alacak'
        FROM musteriler m
        JOIN kullanicilar k ON m.kullanici_id = k.kullanici_id";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    data_musteri.DataSource = null;
                    data_musteri.DataSource = table;

                    AddButtonColumn(data_musteri, "Düzenle", "İşlem", "Düzenle");
                }

                //Log Kaydı
                YoneticiLogIslem(GirisEkrani.CurrentUserId, "Veri Çekme", "musteriler", "Müşteri bilgileri çekildi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Müşteri verileri çekilirken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void radio_musteri_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void data_musteri_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && data_musteri.Columns[e.ColumnIndex].Name == "Düzenle")
            {
                string musteriId = data_musteri.Rows[e.RowIndex].Cells["Müşteri ID"].Value.ToString();
                MusteriBilgiDuzenle musteriForm = new MusteriBilgiDuzenle(Convert.ToInt32(musteriId));
                musteriForm.ShowDialog();

                //Log Kaydı
                YoneticiLogIslem(GirisEkrani.CurrentUserId, "Düzenleme", "musteriler", $"Müşteri ID: {musteriId} düzenlendi.");
            }
        }

        private void btn_siparisVeri_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=bitirme_projesi;Uid=root;Pwd=138426;";
            string query = @"SELECT siparis_id AS 'Sipariş ID', 
                            musteri_id AS 'Müşteri ID', 
                            toplam_tutar AS 'Toplam Tutar', 
                            siparis_durumu AS 'Sipariş Durumu' 
                     FROM siparisler";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    data_muteriSiparis.DataSource = null;
                    data_muteriSiparis.DataSource = table;

                    AddButtonColumn(data_muteriSiparis, "Düzenle", "İşlem", "Düzenle");
                }
                //Log Kaydı
                YoneticiLogIslem(GirisEkrani.CurrentUserId, "Veri Çekme", "siparisler", "Sipariş bilgileri çekildi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Sipariş verileri çekilirken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void data_muteriSiparis_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && data_muteriSiparis.Columns[e.ColumnIndex].Name == "Düzenle")
            {
                string siparisId = data_muteriSiparis.Rows[e.RowIndex].Cells["Sipariş ID"].Value.ToString();
                SiparisDuzenleForm siparisForm = new SiparisDuzenleForm(Convert.ToInt32(siparisId));
                siparisForm.ShowDialog();

                //Log Kaydı
                YoneticiLogIslem(GirisEkrani.CurrentUserId, "Düzenleme", "siparisler", $"Sipariş ID: {siparisId} düzenlendi.");
            }
        }

        private void AddButtonColumn(DataGridView dataGridView, string name, string headerText, string buttonText)
        {
            if (dataGridView.Columns.Contains(name)) return;

            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn
            {
                Name = name,
                HeaderText = headerText,
                Text = buttonText,
                UseColumnTextForButtonValue = true
            };
            dataGridView.Columns.Add(buttonColumn);
        }

        private void AddButtonColumnForCalisan(string name, string text)
        {
            if (data_calisan.Columns.Contains(name))
                return;

            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn
            {
                Name = name,
                HeaderText = text,
                Text = text,
                UseColumnTextForButtonValue = true
            };

            data_calisan.Columns.Add(buttonColumn);
        }


        private void btn_calisanVeri_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=bitirme_projesi;Uid=root;Pwd=138426;";
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"
                SELECT 
                    calisanlar.calisan_id AS 'Çalışan ID',
                    kullanicilar.ad_soyad AS 'Ad Soyad',
                    calisanlar.gorev AS 'Görev',
                    calisanlar.vardiya_baslangic_zamani AS 'Vardiya Başlangıç',
                    calisanlar.vardiya_bitis_zamani AS 'Vardiya Bitiş',
                    CASE 
                        WHEN calisanlar.izin_durumu = 1 THEN 'İzinli'
                        ELSE 'İzin Yok'
                    END AS 'İzin Durumu',
                    calisanlar.calisma_durumu AS 'Durum',
                    calisanlar.yetki_seviyesi AS 'Yetki Seviyesi'
                FROM 
                    calisanlar
                JOIN 
                    kullanicilar ON calisanlar.kullanici_id = kullanicilar.kullanici_id";

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        data_calisan.DataSource = dt;

                        // DataGridView ayarları
                        data_calisan.AllowUserToAddRows = false;
                        data_calisan.AllowUserToDeleteRows = false;
                        data_calisan.ReadOnly = true; // Düzenleme yetkisi için buton kullanılacak
                        data_calisan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                        // Düzenleme butonunu ekle
                        AddButtonColumnForCalisan("Düzenle", "Düzenle");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Çalışan bilgileri çekilemedi: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void data_calisan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && data_calisan.Columns[e.ColumnIndex].Name == "Düzenle")
            {
                // Çalışan ID'yi al
                string calisanId = data_calisan.Rows[e.RowIndex].Cells["Çalışan ID"].Value.ToString();

                // Düzenleme formunu aç
                CalisanDuzenle calisanDuzenleForm = new CalisanDuzenle(calisanId);
                calisanDuzenleForm.ShowDialog();
            }
        }

        private void btn_stokVeri_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=bitirme_projesi;Uid=root;Pwd=138426;";
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"
                SELECT 
                    urun_id AS 'Ürün ID',
                    urun_adi AS 'Ürün Adı',
                    stok_miktari AS 'Stok Miktarı',
                    fiyat AS 'Fiyat',
                    eklenme_tarihi AS 'Eklenme Tarihi',
                    guncellenme_tarihi AS 'Güncellenme Tarihi'
                FROM urunler";

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        data_Stok.DataSource = table;

                        // DataGridView ayarları
                        data_Stok.AllowUserToAddRows = false;
                        data_Stok.AllowUserToDeleteRows = false;
                        data_Stok.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                        // Düzenle butonunu ekle
                        AddStokButtons();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Stok verileri yüklenirken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddButtonColumnForStok(string name, string text)
        {
            // Eğer buton sütunu zaten varsa eklemeyi tekrar yapma
            if (data_Stok.Columns.Contains(name))
                return;

            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn
            {
                Name = name,
                HeaderText = text,
                Text = text,
                UseColumnTextForButtonValue = true
            };

            data_Stok.Columns.Add(buttonColumn);
        }

        private void AddStokButtons()
        {
            AddButtonColumnForStok("Düzenle", "Düzenle");
        }

        private void data_Stok_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && data_Stok.Columns[e.ColumnIndex].Name == "Düzenle")
            {
                // Seçili satırdan verileri al
                DataGridViewRow selectedRow = data_Stok.Rows[e.RowIndex];
                string urunId = selectedRow.Cells["Ürün ID"].Value?.ToString();
                string urunAdi = selectedRow.Cells["Ürün Adı"].Value?.ToString();
                string stokMiktari = selectedRow.Cells["Stok Miktarı"].Value?.ToString();
                string fiyat = selectedRow.Cells["Fiyat"].Value?.ToString();
                string guncellenmeTarihi = selectedRow.Cells["Güncellenme Tarihi"].Value?.ToString();

                // StokDuzenle formunu aç ve verileri gönder
                StokDuzenle stokDuzenleForm = new StokDuzenle(urunId, urunAdi, stokMiktari, fiyat, guncellenmeTarihi);
                stokDuzenleForm.ShowDialog();

                // Düzenleme sonrası tabloyu yenile
                btn_stokVeri.PerformClick();
            }
        }

        private void btn_satisVeri_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=bitirme_projesi;Uid=root;Pwd=138426;";
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"
                SELECT 
                    siparis_id AS 'Sipariş ID',
                    musteri_id AS 'Müşteri ID',
                    siparis_tarihi AS 'Sipariş Tarihi',
                    toplam_tutar AS 'Toplam Tutar',
                    siparis_durumu AS 'Sipariş Durumu'
                FROM siparisler";

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        data_satisRapor.DataSource = table;

                        // DataGridView ayarları
                        data_satisRapor.AllowUserToAddRows = false;
                        data_satisRapor.AllowUserToDeleteRows = false;
                        data_satisRapor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Satış raporları yüklenirken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_logVeri_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=bitirme_projesi;Uid=root;Pwd=138426;";
            string query = "SELECT * FROM loglar";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        data_logKaydi.DataSource = table;
                    }
                }
                FillComboBox();

                MessageBox.Show("Log verileri başarıyla yüklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FillComboBox()
        {
            string connectionString = "Server=localhost;Database=bitirme_projesi;Uid=root;Pwd=138426;";
            string query = "SHOW COLUMNS FROM loglar"; // loglar tablosunun sütunlarını getir

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            cmb_filtreKriter.Items.Clear(); // Eski değerleri temizle
                            while (reader.Read())
                            {
                                string columnName = reader["Field"].ToString(); // Sütun adı
                                cmb_filtreKriter.Items.Add(columnName);
                            }
                        }
                    }
                }

                // Varsayılan bir değer seç
                if (cmb_filtreKriter.Items.Count > 0)
                    cmb_filtreKriter.SelectedIndex = 0; // İlk sütunu seç
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ComboBox doldurulamadı: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btn_logAra_Click(object sender, EventArgs e)
        {
            string selectedColumn = cmb_filtreKriter.SelectedItem?.ToString();
            string filterText = txt_filtreArama.Text.Trim();

            if (string.IsNullOrEmpty(selectedColumn) || string.IsNullOrEmpty(filterText))
            {
                MessageBox.Show("Lütfen bir kriter seçin ve arama metni girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = "Server=localhost;Database=bitirme_projesi;Uid=root;Pwd=138426;";
            string query = $"SELECT * FROM loglar WHERE {selectedColumn} LIKE @filterText";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@filterText", $"%{filterText}%");
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        data_logKaydi.DataSource = table;
                    }
                }

                MessageBox.Show("Filtreleme işlemi tamamlandı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void TabPage_Load(object sender, EventArgs e)
        {

        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var mailAddress = new System.Net.Mail.MailAddress(email);
                return mailAddress.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private int GetNextAvailableId(string rol)
        {

            string connectionString = "Server=localhost;Database=bitirme_projesi;Uid=root;Pwd=138426;";
            int nextId = 0;

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "";

                    // Yönetici için ID aralığı 0-1000
                    if (rol == "Yonetici")
                        query = "SELECT IFNULL(MAX(kullanici_id), 0) + 1 AS nextId FROM kullanicilar WHERE kullanici_id BETWEEN 0 AND 1000";

                    // Müşteri için ID aralığı 5000 ve üzeri
                    else if (rol == "Musteri")
                        query = "SELECT IFNULL(MAX(kullanici_id), 4999) + 1 AS nextId FROM kullanicilar WHERE kullanici_id >= 5000";

                    // Çalışan için ID aralığı 1000-4999 (Seviye 1, 2, 3)
                    else if (rol == "CalisanSeviye1")
                        query = "SELECT IFNULL(MAX(kullanici_id), 1000) + 1 AS nextId FROM kullanicilar WHERE kullanici_id BETWEEN 1000 AND 3499";
                    else if (rol == "CalisanSeviye2")
                        query = "SELECT IFNULL(MAX(kullanici_id), 3500) + 1 AS nextId FROM kullanicilar WHERE kullanici_id BETWEEN 3500 AND 4499";
                    else if (rol == "CalisanSeviye3")
                        query = "SELECT IFNULL(MAX(kullanici_id), 4500) + 1 AS nextId FROM kullanicilar WHERE kullanici_id BETWEEN 4500 AND 4999";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        nextId = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ID otomatik belirlenemedi (Seviye: {rol}, Hata: {ex.Message})", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return nextId;
        }

        private void InsertIlgiliTabloId(MySqlConnection connection, string rol, int kullaniciId)
        {
            MessageBox.Show($"InsertIlgiliTabloId metodu çağrıldı! Rol: {rol}, Kullanıcı ID: {kullaniciId}");

            if (rol == "Calisan")
            {
                string insertCalisanQuery = @"
        INSERT INTO calisanlar (kullanici_id, gorev, vardiya_baslangic_zamani, vardiya_bitis_zamani, izin_durumu, calisma_durumu, yetki_seviyesi)
        VALUES (@kullaniciId, @gorev, NULL, NULL, 0, 'Aktif', @yetkiSeviyesi);";

                using (MySqlCommand cmd = new MySqlCommand(insertCalisanQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@kullaniciId", kullaniciId);
                    cmd.Parameters.AddWithValue("@gorev", string.IsNullOrEmpty(txtAdres.Text) ? DBNull.Value : (object)txtAdres.Text);
                    cmd.Parameters.AddWithValue("@yetkiSeviyesi", (int)numYetkiSeviyesi.Value);
                    cmd.ExecuteNonQuery();
                }
            }
            else if (rol == "Musteri")
            {
                string insertMusteriQuery = @"
        INSERT INTO musteriler (kullanici_id, telefon, adres, kayit_tarihi, eposta)
        VALUES (@kullaniciId, @telefon, @adres, NOW(), @eposta);";

                using (MySqlCommand cmd = new MySqlCommand(insertMusteriQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@kullaniciId", kullaniciId);
                    cmd.Parameters.AddWithValue("@telefon", string.IsNullOrEmpty(txtTelefon.Text) ? DBNull.Value : (object)txtTelefon.Text);
                    cmd.Parameters.AddWithValue("@adres", string.IsNullOrEmpty(txtAdres.Text) ? DBNull.Value : (object)txtAdres.Text);
                    cmd.Parameters.AddWithValue("@eposta", txtEposta.Text); // E-posta burada ekleniyor
                    cmd.ExecuteNonQuery();
                }
            }
            else if (rol == "Yonetici")
            {
                string insertYoneticiQuery = @"
        INSERT INTO yoneticiler (kullanici_id)
        VALUES (@kullaniciId);";

                using (MySqlCommand cmd = new MySqlCommand(insertYoneticiQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@kullaniciId", kullaniciId);
                    cmd.ExecuteNonQuery();
                }
            }
        }



        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string rol = cmbRol.SelectedItem?.ToString(); // ComboBox'tan rol seçimi
            if (string.IsNullOrEmpty(rol))
            {
                MessageBox.Show("Lütfen bir rol seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Rol doğrulama
            if (rol != "Yonetici" && rol != "Calisan" && rol != "Musteri")
            {
                MessageBox.Show("Geçersiz rol seçimi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kullanıcı ID kontrolü
            int yeniId = 0;
            if (!int.TryParse(txtKullaniciId.Text, out yeniId))
            {
                MessageBox.Show("Geçerli bir kullanıcı ID girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // E-posta doğrulama
            if (!IsValidEmail(txtEposta.Text))
            {
                MessageBox.Show("Geçerli bir e-posta adresi girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = "Server=localhost;Database=bitirme_projesi;Uid=root;Pwd=138426;";
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string insertQuery = @"
            INSERT INTO kullanicilar (kullanici_id, ad_soyad, eposta, sifre, rol, kayit_tarihi)
            VALUES (@kullaniciId, @adSoyad, @eposta, @sifre, @rol, NOW())";

                    using (MySqlCommand cmd = new MySqlCommand(insertQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@kullaniciId", yeniId);
                        cmd.Parameters.AddWithValue("@adSoyad", txtAdSoyad.Text);
                        cmd.Parameters.AddWithValue("@eposta", txtEposta.Text);
                        cmd.Parameters.AddWithValue("@sifre", txtSifre.Text);
                        cmd.Parameters.AddWithValue("@rol", rol);
                        cmd.ExecuteNonQuery();
                    }

                    InsertIlgiliTabloId(connection, rol, yeniId);

                    MessageBox.Show("Kullanıcı başarıyla kaydedildi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata oluştu: {ex.Message}\nStackTrace: {ex.StackTrace}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtAdSoyad.Clear();
            txtSifre.Clear();
            txtTelefon.Clear();
            txtEposta.Clear();
            txtAdres.Clear();
            numYetkiSeviyesi.Value = 0;
            cmbRol.SelectedIndex = 0;
        }

        private void cmbRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            string rol = cmbRol.SelectedItem?.ToString(); // Combobox'tan seçilen rolü al

            // Enum değerlerini kontrol et
            if (!new[] { "Yonetici", "Calisan", "Musteri" }.Contains(rol))
            {
                MessageBox.Show("Geçersiz rol seçimi. Lütfen doğru bir rol seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Hatalı seçimde işlemi durdur
            }

            int nextId = 0;

            // Rol bazlı ID oluştur
            if (rol == "Yonetici")
                nextId = GetNextAvailableId("Yonetici");
            else if (rol == "Calisan")
            {
                nextId = GetNextAvailableId("CalisanSeviye1"); // Varsayılan seviye 1
                numYetkiSeviyesi.Value = 1;
            }
            else if (rol == "Musteri")
                nextId = GetNextAvailableId("Musteri");

            txtKullaniciId.Text = nextId.ToString(); // ID'yi textbox'a yaz
        }

        private void numYetkiSeviyesi_ValueChanged(object sender, EventArgs e)
        {
            string rol = cmbRol.SelectedItem?.ToString(); // Seçilen rol
            int seviye = (int)numYetkiSeviyesi.Value; // Seçilen çalışan seviyesi

            if (rol != "Calisan")
            {
                MessageBox.Show("Sadece çalışanlar için seviye seçebilirsiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Çalışan değilse işlem iptal
            }

            int yeniId = 0;

            // Çalışan seviyesine göre ID aralığını belirle
            if (seviye == 1) // Seviye 1: 1000-3499
            {
                yeniId = GetNextAvailableId("CalisanSeviye1");
            }
            else if (seviye == 2) // Seviye 2: 3500-4499
            {
                yeniId = GetNextAvailableId("CalisanSeviye2");
            }
            else if (seviye == 3) // Seviye 3: 4500-4999
            {
                yeniId = GetNextAvailableId("CalisanSeviye3");
            }
            else
            {
                MessageBox.Show("Geçersiz seviye seçimi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Geçersiz seviye seçimi
            }

            // ID'yi güncelle
            txtKullaniciId.Text = yeniId.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TestDatabaseConsistency();
        }

        private void TestDatabaseConsistency()
        {
            string connectionString = "Server=localhost;Database=bitirme_projesi;Uid=root;Pwd=138426;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = @"
        SELECT k.kullanici_id, k.rol,
               CASE
                   WHEN k.rol = 'Musteri' AND m.kullanici_id IS NULL THEN 'Eksik Musteri'
                   WHEN k.rol = 'Yonetici' AND y.kullanici_id IS NULL THEN 'Eksik Yonetici'
                   WHEN k.rol = 'Calisan' AND c.kullanici_id IS NULL THEN 'Eksik Calisan'
                   ELSE 'Tamam'
               END AS Durum
        FROM kullanicilar k
        LEFT JOIN musteriler m ON k.kullanici_id = m.kullanici_id
        LEFT JOIN yoneticiler y ON k.kullanici_id = y.kullanici_id
        LEFT JOIN calisanlar c ON k.kullanici_id = c.kullanici_id";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        MessageBox.Show($"Kullanıcı ID: {reader["kullanici_id"]}, Rol: {reader["rol"]}, Durum: {reader["Durum"]}");
                    }
                }
            }
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void btn_bilgileriGetir_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=bitirme_projesi;Uid=root;Pwd=138426;";
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT ad_soyad, eposta, sifre FROM kullanicilar WHERE kullanici_id = @kullaniciId";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@kullaniciId", GirisEkrani.CurrentUserId); // Giriş yapan kullanıcının ID'si

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txt_adSoyad.Text = reader["ad_soyad"].ToString();
                                txt_eposta.Text = reader["eposta"].ToString();
                                txtsfr.Text = reader["sifre"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Bilgiler getirilemedi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=bitirme_projesi;Uid=root;Pwd=138426;";
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "UPDATE kullanicilar SET ad_soyad = @adSoyad, eposta = @eposta, sifre = @sifre WHERE kullanici_id = @kullaniciId";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@adSoyad", txt_adSoyad.Text.Trim());
                        cmd.Parameters.AddWithValue("@eposta", txt_eposta.Text.Trim());
                        cmd.Parameters.AddWithValue("@sifre", txtsfr.Text.Trim());
                        cmd.Parameters.AddWithValue("@kullaniciId", GirisEkrani.CurrentUserId);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Bilgiler başarıyla güncellendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Bilgiler güncellenemedi. Lütfen tekrar deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btn_feedbackListe_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=bitirme_projesi;Uid=root;Pwd=138426;";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Feedback tablosundan verileri çek
                    string query = "SELECT id AS 'Feedback ID', musteri_id AS 'Müşteri ID', geri_bildirim AS 'Geri Bildirim', tarih AS 'Tarih' FROM feedback";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        // DataGridView'e bağla
                        data_feedbackListe.DataSource = table;
                        data_feedbackListe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells; // Kolonları sığdır
                    }
                }

                MessageBox.Show("Feedback verileri başarıyla yüklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void data_feedbackListe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Tıklanan satırın indexini al
                int rowIndex = e.RowIndex;

                // Geçerli bir satıra tıklandığından emin ol
                if (rowIndex >= 0)
                {
                    // Tıklanan satırın bilgilerini al
                    DataGridViewRow selectedRow = data_feedbackListe.Rows[rowIndex];
                    string feedbackId = selectedRow.Cells["Feedback ID"].Value?.ToString();
                    string musteriId = selectedRow.Cells["Müşteri ID"].Value?.ToString();
                    string geriBildirim = selectedRow.Cells["Geri Bildirim"].Value?.ToString();
                    string tarih = selectedRow.Cells["Tarih"].Value?.ToString();

                    // Bilgileri MessageBox ile göster
                    MessageBox.Show(
                        $"Feedback ID: {feedbackId}\n" +
                        $"Müşteri ID: {musteriId}\n" +
                        $"Geri Bildirim: {geriBildirim}\n" +
                        $"Tarih: {tarih}",
                        "Satır Detayları",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}