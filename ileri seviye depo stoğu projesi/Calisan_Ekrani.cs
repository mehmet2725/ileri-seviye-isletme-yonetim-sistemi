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

        private void AddButtonColumns()
        {
            if (data_siparisBilgi.Columns["Onayla"] == null)
            {
                DataGridViewButtonColumn onaylaButton = new DataGridViewButtonColumn
                {
                    Name = "Onayla",
                    HeaderText = "Onayla",
                    Text = "Onayla",
                    UseColumnTextForButtonValue = true
                };
                data_siparisBilgi.Columns.Add(onaylaButton);
            }

            if (data_siparisBilgi.Columns["İptal Et"] == null)
            {
                DataGridViewButtonColumn iptalEtButton = new DataGridViewButtonColumn
                {
                    Name = "İptal Et",
                    HeaderText = "İptal Et",
                    Text = "İptal Et",
                    UseColumnTextForButtonValue = true
                };
                data_siparisBilgi.Columns.Add(iptalEtButton);
            }
        }


        private void btn_SiparisBilgileri_Click(object sender, EventArgs e)
        {
            // Yetki kontrolü, veri bağlantısından önce yapılmalı
            if (GirisEkrani.CurrentUserYetkiSeviyesi < 2)
            {
                MessageBox.Show("Bu işlemi gerçekleştirmek için yeterli yetkiniz yok.", "Yetki Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Fonksiyonu burada bitiriyoruz
            }

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

                        data_siparisBilgi.DataSource = table;

                        // Yetki seviyesine göre ayarlar
                        if (GirisEkrani.CurrentUserYetkiSeviyesi == 2)
                        {
                            data_siparisBilgi.ReadOnly = true; // Sadece görüntüleme
                        }
                        else if (GirisEkrani.CurrentUserYetkiSeviyesi == 3)
                        {
                            data_siparisBilgi.ReadOnly = false; // Düzenleme yetkisi
                        }
                        if (!data_siparisBilgi.Columns.Contains("Onayla") && !data_siparisBilgi.Columns.Contains("İptal Et"))
                        {
                            AddButtonColumns(); // Eğer buton sütunları yoksa ekle
                        }
                        // Datagrid ayarları
                        data_siparisBilgi.AllowUserToAddRows = false;
                        data_siparisBilgi.AllowUserToDeleteRows = false;
                        data_siparisBilgi.AllowUserToOrderColumns = false;
                        data_siparisBilgi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                        
                    }
                }
            }
            
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        private void UpdateSiparisDurumu(string siparisId, string yeniDurum)
        {
            string connectionString = "Server=localhost;Database=bitirme_projesi;Uid=root;Pwd=138426;";
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Mevcut sipariş durumunu kontrol et
                    string queryCheck = "SELECT siparis_durumu FROM siparisler WHERE siparis_id = @siparisId";
                    using (MySqlCommand cmdCheck = new MySqlCommand(queryCheck, connection))
                    {
                        cmdCheck.Parameters.AddWithValue("@siparisId", siparisId);
                        string mevcutDurum = cmdCheck.ExecuteScalar()?.ToString();

                        // Eğer mevcut durum "İptal" ise, "Tamamlandı" yapılamaz
                        if (mevcutDurum == "Iptal" && yeniDurum == "Tamamlandi")
                        {
                            MessageBox.Show("İptal edilmiş bir sipariş tamamlandı olarak değiştirilemez.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        // Eğer mevcut durum "Tamamlandı" ise, "İptal" yapılamaz
                        if (mevcutDurum == "Tamamlandi" && yeniDurum == "Iptal")
                        {
                            MessageBox.Show("Tamamlanmış bir sipariş iptal edilemez.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // Durum güncelleme sorgusu
                    string queryUpdate = "UPDATE siparisler SET siparis_durumu = @yeniDurum WHERE siparis_id = @siparisId";
                    using (MySqlCommand cmdUpdate = new MySqlCommand(queryUpdate, connection))
                    {
                        cmdUpdate.Parameters.AddWithValue("@yeniDurum", yeniDurum);
                        cmdUpdate.Parameters.AddWithValue("@siparisId", siparisId);

                        int rowsAffected = cmdUpdate.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Sipariş durumu güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LogIslem(siparisId, yeniDurum == "Tamamlandi" ? "Sipariş Onaylandı" : "Sipariş İptal Edildi");
                        }
                        else
                        {
                            MessageBox.Show("Sipariş durumu güncellenemedi. Lütfen tekrar deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

                    if (e.ColumnIndex == data_siparisBilgi.Columns["Onayla"].Index)
                    {
                        UpdateSiparisDurumu(siparisIdStr, "Tamamlandi");
                    }
                    else if (e.ColumnIndex == data_siparisBilgi.Columns["İptal Et"].Index)
                    {
                        UpdateSiparisDurumu(siparisIdStr, "Iptal");
                    }
                    // Düzenleme sütununa tıklandıysa
                    else if (data_siparisBilgi.Columns[e.ColumnIndex].Name == "Düzenle" && GirisEkrani.CurrentUserYetkiSeviyesi == 3)
                    {
                        MessageBox.Show($"Sipariş {siparisIdStr} düzenlenecek.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            // Eğer kullanıcı 3. seviye yetkiye sahipse düzenleme yapılabilir
            if (GirisEkrani.CurrentUserYetkiSeviyesi != 3)
            {
                MessageBox.Show("Bu işlemi gerçekleştirme yetkiniz yok.", "Yetki Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string connectionString = "Server=localhost;Database=bitirme_projesi;Uid=root;Pwd=138426;";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Düzenlenen hücreye ait bilgileri al
                    int rowIndex = e.RowIndex;
                    string columnName = data_siparisBilgi.Columns[e.ColumnIndex].Name;
                    string newValue = data_siparisBilgi.Rows[rowIndex].Cells[e.ColumnIndex].Value?.ToString();
                    string siparisId = data_siparisBilgi.Rows[rowIndex].Cells["siparis_id"].Value?.ToString();

                    if (!string.IsNullOrEmpty(newValue) && !string.IsNullOrEmpty(siparisId))
                    {
                        // SQL sorgusu: ilgili sütunu güncelle
                        string updateQuery = $"UPDATE siparisler SET {columnName} = @newValue WHERE siparis_id = @siparisId";

                        using (MySqlCommand cmd = new MySqlCommand(updateQuery, connection))
                        {
                            cmd.Parameters.AddWithValue("@newValue", newValue);
                            cmd.Parameters.AddWithValue("@siparisId", siparisId);

                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Veri başarıyla güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Veri güncellenemedi. Lütfen tekrar deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        cmd.Parameters.AddWithValue("@kullaniciId", GirisEkrani.CurrentUserId);
                        cmd.Parameters.AddWithValue("@islemTipi", durum.Length > 50 ? durum.Substring(0, 50) : durum); // 50 karakter sınırı koy
                        cmd.Parameters.AddWithValue("@detaylar", $"Sipariş {siparisId} durumu {durum} olarak güncellendi.");
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Loglama sırasında bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
