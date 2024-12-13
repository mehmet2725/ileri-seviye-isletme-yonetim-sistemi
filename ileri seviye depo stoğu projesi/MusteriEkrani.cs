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
    public partial class MusteriEkrani : Form
    {
        public MusteriEkrani(int ilgiliId)
        {
            InitializeComponent();
        }


        // Veritabanı bağlantı bilgileri
       

        private void btn_musteriVeri_Click_1(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=bitirme_projesi;Uid=root;Pwd=138426;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Giriş yapan kullanıcının ID'sine göre müşteri bilgilerini getiriyoruz
                    string query = "SELECT * FROM musteriler WHERE kullanici_id = @kullaniciId";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Kullanıcı ID'sini parametre olarak geçiyoruz
                        command.Parameters.AddWithValue("@kullaniciId", GirisEkrani.CurrentUserId);

                        MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                        DataTable dataTable = new DataTable();

                        // Datagridview'e dolduruyoruz
                        adapter.Fill(dataTable);
                        data_musteriBilgi.DataSource = dataTable;

                        // Log kaydı
                        string logQuery = "INSERT INTO loglar (kullanici_id, islem_tipi, detaylar) VALUES (@kullaniciId, 'Veri Çekme', 'Müşteri bilgileri görüntülendi.')";
                        using (MySqlCommand logCommand = new MySqlCommand(logQuery, connection))
                        {
                            logCommand.Parameters.AddWithValue("@kullaniciId", GirisEkrani.CurrentUserId);
                            logCommand.ExecuteNonQuery();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
