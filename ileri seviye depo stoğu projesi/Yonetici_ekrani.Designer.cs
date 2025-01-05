namespace ileri_seviye_depo_stoğu_projesi
{
    partial class Yonetici_ekrani
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Yonetici_ekrani));
            tabcontrol = new TabControl();
            tab_calisanYonetim = new TabPage();
            btn_calisanVeri = new Button();
            label1 = new Label();
            data_calisan = new DataGridView();
            tab_musteriSiparisYonetim = new TabPage();
            btn_siparisVeri = new Button();
            btn_musteriVeri = new Button();
            data_muteriSiparis = new DataGridView();
            label4 = new Label();
            data_musteri = new DataGridView();
            label3 = new Label();
            tab_stokSatis = new TabPage();
            btn_stokVeri = new Button();
            btn_satisVeri = new Button();
            data_satisRapor = new DataGridView();
            label5 = new Label();
            data_Stok = new DataGridView();
            label6 = new Label();
            tab_logKaydı = new TabPage();
            btn_logAra = new Button();
            label8 = new Label();
            label2 = new Label();
            txt_filtreArama = new TextBox();
            cmb_filtreKriter = new ComboBox();
            btn_logVeri = new Button();
            data_logKaydi = new DataGridView();
            label7 = new Label();
            tab_kayit = new TabPage();
            label16 = new Label();
            txtKullaniciId = new TextBox();
            label14 = new Label();
            btnKaydet = new Button();
            txtAdres = new TextBox();
            txtEposta = new TextBox();
            txtTelefon = new TextBox();
            txtSifre = new TextBox();
            txtAdSoyad = new TextBox();
            numYetkiSeviyesi = new NumericUpDown();
            cmbRol = new ComboBox();
            btnTemizle = new Button();
            label9 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label15 = new Label();
            label10 = new Label();
            Bilgilerim = new TabPage();
            txtsfr = new TextBox();
            btn_guncelle = new Button();
            btn_bilgileriGetir = new Button();
            label19 = new Label();
            label18 = new Label();
            label17 = new Label();
            txt_adSoyad = new TextBox();
            txt_eposta = new TextBox();
            tabPage1 = new TabPage();
            label20 = new Label();
            data_feedbackListe = new DataGridView();
            btn_feedbackListe = new Button();
            btn_geri = new Button();
            tabcontrol.SuspendLayout();
            tab_calisanYonetim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)data_calisan).BeginInit();
            tab_musteriSiparisYonetim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)data_muteriSiparis).BeginInit();
            ((System.ComponentModel.ISupportInitialize)data_musteri).BeginInit();
            tab_stokSatis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)data_satisRapor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)data_Stok).BeginInit();
            tab_logKaydı.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)data_logKaydi).BeginInit();
            tab_kayit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numYetkiSeviyesi).BeginInit();
            Bilgilerim.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)data_feedbackListe).BeginInit();
            SuspendLayout();
            // 
            // tabcontrol
            // 
            tabcontrol.Controls.Add(tab_calisanYonetim);
            tabcontrol.Controls.Add(tab_musteriSiparisYonetim);
            tabcontrol.Controls.Add(tab_stokSatis);
            tabcontrol.Controls.Add(tab_logKaydı);
            tabcontrol.Controls.Add(tab_kayit);
            tabcontrol.Controls.Add(Bilgilerim);
            tabcontrol.Controls.Add(tabPage1);
            tabcontrol.Location = new Point(93, 55);
            tabcontrol.Name = "tabcontrol";
            tabcontrol.SelectedIndex = 0;
            tabcontrol.Size = new Size(926, 563);
            tabcontrol.TabIndex = 0;
            // 
            // tab_calisanYonetim
            // 
            tab_calisanYonetim.Controls.Add(btn_calisanVeri);
            tab_calisanYonetim.Controls.Add(label1);
            tab_calisanYonetim.Controls.Add(data_calisan);
            tab_calisanYonetim.Location = new Point(4, 24);
            tab_calisanYonetim.Name = "tab_calisanYonetim";
            tab_calisanYonetim.Padding = new Padding(3);
            tab_calisanYonetim.Size = new Size(918, 535);
            tab_calisanYonetim.TabIndex = 0;
            tab_calisanYonetim.Text = "Çalışan Yönetimi";
            tab_calisanYonetim.UseVisualStyleBackColor = true;
            tab_calisanYonetim.Click += tab_calisanYonetim_Click;
            // 
            // btn_calisanVeri
            // 
            btn_calisanVeri.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            btn_calisanVeri.ForeColor = Color.Black;
            btn_calisanVeri.Location = new Point(756, 399);
            btn_calisanVeri.Name = "btn_calisanVeri";
            btn_calisanVeri.Size = new Size(140, 62);
            btn_calisanVeri.TabIndex = 9;
            btn_calisanVeri.Text = "Veri Çek";
            btn_calisanVeri.UseVisualStyleBackColor = true;
            btn_calisanVeri.Click += btn_calisanVeri_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(46, 75);
            label1.Name = "label1";
            label1.Size = new Size(163, 30);
            label1.TabIndex = 1;
            label1.Text = "Çalışan Bilgileri";
            // 
            // data_calisan
            // 
            data_calisan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_calisan.Location = new Point(46, 115);
            data_calisan.Name = "data_calisan";
            data_calisan.Size = new Size(850, 278);
            data_calisan.TabIndex = 0;
            data_calisan.CellClick += data_calisan_CellClick;
            // 
            // tab_musteriSiparisYonetim
            // 
            tab_musteriSiparisYonetim.Controls.Add(btn_siparisVeri);
            tab_musteriSiparisYonetim.Controls.Add(btn_musteriVeri);
            tab_musteriSiparisYonetim.Controls.Add(data_muteriSiparis);
            tab_musteriSiparisYonetim.Controls.Add(label4);
            tab_musteriSiparisYonetim.Controls.Add(data_musteri);
            tab_musteriSiparisYonetim.Controls.Add(label3);
            tab_musteriSiparisYonetim.Location = new Point(4, 24);
            tab_musteriSiparisYonetim.Name = "tab_musteriSiparisYonetim";
            tab_musteriSiparisYonetim.Padding = new Padding(3);
            tab_musteriSiparisYonetim.Size = new Size(918, 535);
            tab_musteriSiparisYonetim.TabIndex = 1;
            tab_musteriSiparisYonetim.Text = "Müşteri ve Sipariş Yönetimi";
            tab_musteriSiparisYonetim.UseVisualStyleBackColor = true;
            // 
            // btn_siparisVeri
            // 
            btn_siparisVeri.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btn_siparisVeri.ForeColor = Color.Black;
            btn_siparisVeri.Location = new Point(804, 391);
            btn_siparisVeri.Name = "btn_siparisVeri";
            btn_siparisVeri.Size = new Size(84, 32);
            btn_siparisVeri.TabIndex = 10;
            btn_siparisVeri.Text = "Veri Çek";
            btn_siparisVeri.UseVisualStyleBackColor = true;
            btn_siparisVeri.Click += btn_siparisVeri_Click;
            // 
            // btn_musteriVeri
            // 
            btn_musteriVeri.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btn_musteriVeri.ForeColor = Color.Black;
            btn_musteriVeri.Location = new Point(59, 391);
            btn_musteriVeri.Name = "btn_musteriVeri";
            btn_musteriVeri.Size = new Size(84, 32);
            btn_musteriVeri.TabIndex = 9;
            btn_musteriVeri.Text = "Veri Çek";
            btn_musteriVeri.UseVisualStyleBackColor = true;
            btn_musteriVeri.Click += btn_musteriVeri_Click;
            // 
            // data_muteriSiparis
            // 
            data_muteriSiparis.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_muteriSiparis.Location = new Point(476, 101);
            data_muteriSiparis.Name = "data_muteriSiparis";
            data_muteriSiparis.Size = new Size(412, 284);
            data_muteriSiparis.TabIndex = 3;
            data_muteriSiparis.CellClick += data_muteriSiparis_CellClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(547, 43);
            label4.Name = "label4";
            label4.Size = new Size(143, 25);
            label4.TabIndex = 2;
            label4.Text = "Sipariş Bilgileri";
            // 
            // data_musteri
            // 
            data_musteri.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_musteri.Location = new Point(40, 101);
            data_musteri.Name = "data_musteri";
            data_musteri.Size = new Size(391, 284);
            data_musteri.TabIndex = 1;
            data_musteri.CellClick += data_musteri_CellClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(95, 43);
            label3.Name = "label3";
            label3.Size = new Size(147, 25);
            label3.TabIndex = 0;
            label3.Text = "Müşteri Bilgleri";
            label3.Click += label3_Click;
            // 
            // tab_stokSatis
            // 
            tab_stokSatis.Controls.Add(btn_stokVeri);
            tab_stokSatis.Controls.Add(btn_satisVeri);
            tab_stokSatis.Controls.Add(data_satisRapor);
            tab_stokSatis.Controls.Add(label5);
            tab_stokSatis.Controls.Add(data_Stok);
            tab_stokSatis.Controls.Add(label6);
            tab_stokSatis.Location = new Point(4, 24);
            tab_stokSatis.Name = "tab_stokSatis";
            tab_stokSatis.Padding = new Padding(3);
            tab_stokSatis.Size = new Size(918, 535);
            tab_stokSatis.TabIndex = 2;
            tab_stokSatis.Text = "Stok ve Satış Raporları";
            tab_stokSatis.UseVisualStyleBackColor = true;
            // 
            // btn_stokVeri
            // 
            btn_stokVeri.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btn_stokVeri.ForeColor = Color.Black;
            btn_stokVeri.Location = new Point(304, 411);
            btn_stokVeri.Name = "btn_stokVeri";
            btn_stokVeri.Size = new Size(84, 32);
            btn_stokVeri.TabIndex = 11;
            btn_stokVeri.Text = "Veri Çek";
            btn_stokVeri.UseVisualStyleBackColor = true;
            btn_stokVeri.Click += btn_stokVeri_Click;
            // 
            // btn_satisVeri
            // 
            btn_satisVeri.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btn_satisVeri.ForeColor = Color.Black;
            btn_satisVeri.Location = new Point(721, 411);
            btn_satisVeri.Name = "btn_satisVeri";
            btn_satisVeri.Size = new Size(84, 32);
            btn_satisVeri.TabIndex = 10;
            btn_satisVeri.Text = "Veri Çek";
            btn_satisVeri.UseVisualStyleBackColor = true;
            btn_satisVeri.Click += btn_satisVeri_Click;
            // 
            // data_satisRapor
            // 
            data_satisRapor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_satisRapor.Location = new Point(473, 121);
            data_satisRapor.Name = "data_satisRapor";
            data_satisRapor.Size = new Size(419, 284);
            data_satisRapor.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.Location = new Point(496, 63);
            label5.Name = "label5";
            label5.Size = new Size(140, 25);
            label5.TabIndex = 6;
            label5.Text = "Satış Raporları";
            // 
            // data_Stok
            // 
            data_Stok.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_Stok.Location = new Point(6, 121);
            data_Stok.Name = "data_Stok";
            data_Stok.Size = new Size(415, 284);
            data_Stok.TabIndex = 5;
            data_Stok.CellClick += data_Stok_CellClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.Location = new Point(6, 63);
            label6.Name = "label6";
            label6.Size = new Size(125, 25);
            label6.TabIndex = 4;
            label6.Text = "Stok Bilgileri";
            // 
            // tab_logKaydı
            // 
            tab_logKaydı.Controls.Add(btn_logAra);
            tab_logKaydı.Controls.Add(label8);
            tab_logKaydı.Controls.Add(label2);
            tab_logKaydı.Controls.Add(txt_filtreArama);
            tab_logKaydı.Controls.Add(cmb_filtreKriter);
            tab_logKaydı.Controls.Add(btn_logVeri);
            tab_logKaydı.Controls.Add(data_logKaydi);
            tab_logKaydı.Controls.Add(label7);
            tab_logKaydı.Location = new Point(4, 24);
            tab_logKaydı.Name = "tab_logKaydı";
            tab_logKaydı.Padding = new Padding(3);
            tab_logKaydı.Size = new Size(918, 535);
            tab_logKaydı.TabIndex = 4;
            tab_logKaydı.Text = "Log Kaydı";
            tab_logKaydı.UseVisualStyleBackColor = true;
            // 
            // btn_logAra
            // 
            btn_logAra.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btn_logAra.Location = new Point(708, 43);
            btn_logAra.Name = "btn_logAra";
            btn_logAra.Size = new Size(86, 31);
            btn_logAra.TabIndex = 16;
            btn_logAra.Text = "Log Ara";
            btn_logAra.UseVisualStyleBackColor = true;
            btn_logAra.Click += btn_logAra_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(644, 14);
            label8.Name = "label8";
            label8.Size = new Size(251, 15);
            label8.TabIndex = 15;
            label8.Text = "Filtreleme İşleminden Önce Lütfen Veri Çekiniz";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(445, 29);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 14;
            label2.Text = "Filtrele";
            // 
            // txt_filtreArama
            // 
            txt_filtreArama.Location = new Point(571, 52);
            txt_filtreArama.Name = "txt_filtreArama";
            txt_filtreArama.Size = new Size(100, 23);
            txt_filtreArama.TabIndex = 13;
            // 
            // cmb_filtreKriter
            // 
            cmb_filtreKriter.FormattingEnabled = true;
            cmb_filtreKriter.Location = new Point(425, 52);
            cmb_filtreKriter.Name = "cmb_filtreKriter";
            cmb_filtreKriter.Size = new Size(121, 23);
            cmb_filtreKriter.TabIndex = 12;
            // 
            // btn_logVeri
            // 
            btn_logVeri.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            btn_logVeri.ForeColor = Color.Black;
            btn_logVeri.Location = new Point(708, 432);
            btn_logVeri.Name = "btn_logVeri";
            btn_logVeri.Size = new Size(104, 48);
            btn_logVeri.TabIndex = 11;
            btn_logVeri.Text = "Veri Çek";
            btn_logVeri.UseVisualStyleBackColor = true;
            btn_logVeri.Click += btn_logVeri_Click;
            // 
            // data_logKaydi
            // 
            data_logKaydi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_logKaydi.Location = new Point(94, 89);
            data_logKaydi.Name = "data_logKaydi";
            data_logKaydi.Size = new Size(718, 337);
            data_logKaydi.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label7.Location = new Point(94, 29);
            label7.Name = "label7";
            label7.Size = new Size(123, 25);
            label7.TabIndex = 6;
            label7.Text = "Log Kayıtları";
            // 
            // tab_kayit
            // 
            tab_kayit.Controls.Add(label16);
            tab_kayit.Controls.Add(txtKullaniciId);
            tab_kayit.Controls.Add(label14);
            tab_kayit.Controls.Add(btnKaydet);
            tab_kayit.Controls.Add(txtAdres);
            tab_kayit.Controls.Add(txtEposta);
            tab_kayit.Controls.Add(txtTelefon);
            tab_kayit.Controls.Add(txtSifre);
            tab_kayit.Controls.Add(txtAdSoyad);
            tab_kayit.Controls.Add(numYetkiSeviyesi);
            tab_kayit.Controls.Add(cmbRol);
            tab_kayit.Controls.Add(btnTemizle);
            tab_kayit.Controls.Add(label9);
            tab_kayit.Controls.Add(label13);
            tab_kayit.Controls.Add(label12);
            tab_kayit.Controls.Add(label11);
            tab_kayit.Controls.Add(label15);
            tab_kayit.Controls.Add(label10);
            tab_kayit.Location = new Point(4, 24);
            tab_kayit.Name = "tab_kayit";
            tab_kayit.Padding = new Padding(3);
            tab_kayit.Size = new Size(918, 535);
            tab_kayit.TabIndex = 6;
            tab_kayit.Text = "Kayıt Oluştur";
            tab_kayit.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label16.Location = new Point(39, 368);
            label16.Name = "label16";
            label16.Size = new Size(332, 20);
            label16.TabIndex = 11;
            label16.Text = "Çalışan kullancısı eklerken lütfen seviye seçiniz";
            // 
            // txtKullaniciId
            // 
            txtKullaniciId.Location = new Point(512, 98);
            txtKullaniciId.Name = "txtKullaniciId";
            txtKullaniciId.Size = new Size(186, 23);
            txtKullaniciId.TabIndex = 10;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label14.Location = new Point(67, 33);
            label14.Name = "label14";
            label14.Size = new Size(231, 20);
            label14.TabIndex = 9;
            label14.Text = "Lütfen Kullanıcı Detayını Seçiniz";
            // 
            // btnKaydet
            // 
            btnKaydet.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnKaydet.Location = new Point(672, 389);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(103, 48);
            btnKaydet.TabIndex = 8;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // txtAdres
            // 
            txtAdres.Location = new Point(512, 310);
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(186, 23);
            txtAdres.TabIndex = 7;
            // 
            // txtEposta
            // 
            txtEposta.Location = new Point(512, 267);
            txtEposta.Name = "txtEposta";
            txtEposta.Size = new Size(186, 23);
            txtEposta.TabIndex = 7;
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(512, 224);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(186, 23);
            txtTelefon.TabIndex = 7;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(512, 183);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(186, 23);
            txtSifre.TabIndex = 7;
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(512, 141);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(186, 23);
            txtAdSoyad.TabIndex = 7;
            // 
            // numYetkiSeviyesi
            // 
            numYetkiSeviyesi.Location = new Point(392, 365);
            numYetkiSeviyesi.Name = "numYetkiSeviyesi";
            numYetkiSeviyesi.Size = new Size(120, 23);
            numYetkiSeviyesi.TabIndex = 6;
            numYetkiSeviyesi.ValueChanged += numYetkiSeviyesi_ValueChanged;
            // 
            // cmbRol
            // 
            cmbRol.FormattingEnabled = true;
            cmbRol.Location = new Point(174, 74);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(124, 23);
            cmbRol.TabIndex = 5;
            cmbRol.SelectedIndexChanged += cmbRol_SelectedIndexChanged;
            // 
            // btnTemizle
            // 
            btnTemizle.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnTemizle.Location = new Point(537, 389);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(103, 48);
            btnTemizle.TabIndex = 4;
            btnTemizle.Text = "Temizle";
            btnTemizle.UseVisualStyleBackColor = true;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label9.Location = new Point(328, 313);
            label9.Name = "label9";
            label9.Size = new Size(50, 20);
            label9.TabIndex = 1;
            label9.Text = "Adres";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label13.Location = new Point(328, 270);
            label13.Name = "label13";
            label13.Size = new Size(62, 20);
            label13.TabIndex = 1;
            label13.Text = "E-Posta";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label12.Location = new Point(328, 227);
            label12.Name = "label12";
            label12.Size = new Size(133, 20);
            label12.TabIndex = 0;
            label12.Text = "Telefon Numarası";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label11.Location = new Point(328, 186);
            label11.Name = "label11";
            label11.Size = new Size(41, 20);
            label11.TabIndex = 1;
            label11.Text = "Şifre";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label15.Location = new Point(328, 101);
            label15.Name = "label15";
            label15.Size = new Size(86, 20);
            label15.TabIndex = 0;
            label15.Text = "Kullanıcı İd";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label10.Location = new Point(328, 144);
            label10.Name = "label10";
            label10.Size = new Size(75, 20);
            label10.TabIndex = 0;
            label10.Text = "Ad Soyad";
            // 
            // Bilgilerim
            // 
            Bilgilerim.Controls.Add(txtsfr);
            Bilgilerim.Controls.Add(btn_guncelle);
            Bilgilerim.Controls.Add(btn_bilgileriGetir);
            Bilgilerim.Controls.Add(label19);
            Bilgilerim.Controls.Add(label18);
            Bilgilerim.Controls.Add(label17);
            Bilgilerim.Controls.Add(txt_adSoyad);
            Bilgilerim.Controls.Add(txt_eposta);
            Bilgilerim.Location = new Point(4, 24);
            Bilgilerim.Name = "Bilgilerim";
            Bilgilerim.Padding = new Padding(3);
            Bilgilerim.Size = new Size(918, 535);
            Bilgilerim.TabIndex = 7;
            Bilgilerim.Text = "Bilgilerim";
            Bilgilerim.UseVisualStyleBackColor = true;
            // 
            // txtsfr
            // 
            txtsfr.Location = new Point(421, 205);
            txtsfr.Name = "txtsfr";
            txtsfr.Size = new Size(167, 23);
            txtsfr.TabIndex = 6;
            // 
            // btn_guncelle
            // 
            btn_guncelle.Location = new Point(643, 317);
            btn_guncelle.Name = "btn_guncelle";
            btn_guncelle.Size = new Size(111, 48);
            btn_guncelle.TabIndex = 5;
            btn_guncelle.Text = "Güncelle";
            btn_guncelle.UseVisualStyleBackColor = true;
            btn_guncelle.Click += btn_guncelle_Click;
            // 
            // btn_bilgileriGetir
            // 
            btn_bilgileriGetir.Location = new Point(469, 317);
            btn_bilgileriGetir.Name = "btn_bilgileriGetir";
            btn_bilgileriGetir.Size = new Size(119, 48);
            btn_bilgileriGetir.TabIndex = 4;
            btn_bilgileriGetir.Text = "Bilgileri Getir";
            btn_bilgileriGetir.UseVisualStyleBackColor = true;
            btn_bilgileriGetir.Click += btn_bilgileriGetir_Click;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(289, 213);
            label19.Name = "label19";
            label19.Size = new Size(30, 15);
            label19.TabIndex = 3;
            label19.Text = "Şifre";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(289, 163);
            label18.Name = "label18";
            label18.Size = new Size(47, 15);
            label18.TabIndex = 3;
            label18.Text = "E-Posta";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(289, 110);
            label17.Name = "label17";
            label17.Size = new Size(57, 15);
            label17.TabIndex = 3;
            label17.Text = "Ad Soyad";
            label17.Click += label17_Click;
            // 
            // txt_adSoyad
            // 
            txt_adSoyad.Location = new Point(421, 102);
            txt_adSoyad.Name = "txt_adSoyad";
            txt_adSoyad.Size = new Size(167, 23);
            txt_adSoyad.TabIndex = 2;
            // 
            // txt_eposta
            // 
            txt_eposta.Location = new Point(421, 155);
            txt_eposta.Name = "txt_eposta";
            txt_eposta.Size = new Size(167, 23);
            txt_eposta.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label20);
            tabPage1.Controls.Add(data_feedbackListe);
            tabPage1.Controls.Add(btn_feedbackListe);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(918, 535);
            tabPage1.TabIndex = 8;
            tabPage1.Text = "Feedback";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(127, 36);
            label20.Name = "label20";
            label20.Size = new Size(57, 15);
            label20.TabIndex = 2;
            label20.Text = "FeedBack";
            // 
            // data_feedbackListe
            // 
            data_feedbackListe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            data_feedbackListe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_feedbackListe.Location = new Point(65, 74);
            data_feedbackListe.Name = "data_feedbackListe";
            data_feedbackListe.Size = new Size(776, 355);
            data_feedbackListe.TabIndex = 1;
            data_feedbackListe.CellClick += data_feedbackListe_CellClick;
            // 
            // btn_feedbackListe
            // 
            btn_feedbackListe.Location = new Point(766, 448);
            btn_feedbackListe.Name = "btn_feedbackListe";
            btn_feedbackListe.Size = new Size(75, 23);
            btn_feedbackListe.TabIndex = 0;
            btn_feedbackListe.Text = "button1";
            btn_feedbackListe.UseVisualStyleBackColor = true;
            btn_feedbackListe.Click += btn_feedbackListe_Click;
            // 
            // btn_geri
            // 
            btn_geri.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btn_geri.Location = new Point(12, 12);
            btn_geri.Name = "btn_geri";
            btn_geri.Size = new Size(85, 37);
            btn_geri.TabIndex = 8;
            btn_geri.Text = "Geri";
            btn_geri.UseVisualStyleBackColor = true;
            btn_geri.Click += btn_geri_Click;
            // 
            // Yonetici_ekrani
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1091, 666);
            Controls.Add(btn_geri);
            Controls.Add(tabcontrol);
            Name = "Yonetici_ekrani";
            Text = "Yonetici_ekrani";
            Load += Yonetici_ekrani_Load;
            tabcontrol.ResumeLayout(false);
            tab_calisanYonetim.ResumeLayout(false);
            tab_calisanYonetim.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)data_calisan).EndInit();
            tab_musteriSiparisYonetim.ResumeLayout(false);
            tab_musteriSiparisYonetim.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)data_muteriSiparis).EndInit();
            ((System.ComponentModel.ISupportInitialize)data_musteri).EndInit();
            tab_stokSatis.ResumeLayout(false);
            tab_stokSatis.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)data_satisRapor).EndInit();
            ((System.ComponentModel.ISupportInitialize)data_Stok).EndInit();
            tab_logKaydı.ResumeLayout(false);
            tab_logKaydı.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)data_logKaydi).EndInit();
            tab_kayit.ResumeLayout(false);
            tab_kayit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numYetkiSeviyesi).EndInit();
            Bilgilerim.ResumeLayout(false);
            Bilgilerim.PerformLayout();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)data_feedbackListe).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabcontrol;
        private TabPage tab_calisanYonetim;
        private TabPage tab_musteriSiparisYonetim;
        private TabPage tab_stokSatis;
        private TabPage tab_logKaydı;
        private DataGridView data_calisan;
        private Label label1;
        private Label label3;
        private DataGridView data_musteri;
        private DataGridView data_muteriSiparis;
        private Label label4;
        private DataGridView data_Stok;
        private Label label6;
        private DataGridView data_logKaydi;
        private Label label7;
        private Button btn_calisanVeri;
        private Button btn_siparisVeri;
        private Button btn_musteriVeri;
        private Button btn_stokVeri;
        private Button btn_logVeri;
        private TabPage tab_kayit;
        private RadioButton radio_yonetici;
        private RadioButton radio_calisan;
        private RadioButton radio_musteri;
        private Button btn_kayit;
        private TextBox txt_sifre;
        private TextBox txt_KAdi;
        private Label label11;
        private Label label10;
        private Button btn_geri;
        private TextBox txt_ePosta;
        private Label label13;
        private Label label12;
        private Button btn_satisVeri;
        private DataGridView data_satisRapor;
        private Label label5;
        private Button btn_logAra;
        private Label label8;
        private Label label2;
        private TextBox txt_filtreArama;
        private ComboBox cmb_filtreKriter;
        private Label label9;
        private NumericUpDown numYetkiSeviyesi;
        private ComboBox cmbRol;
        private Button btnTemizle;
        private Button btnKaydet;
        private TextBox txtAdres;
        private TextBox txtEposta;
        private TextBox txtTelefon;
        private TextBox txtSifre;
        private TextBox txtAdSoyad;
        private Label label14;
        private TextBox txtKullaniciId;
        private Label label15;
        private Label label16;
        private Button btn_bilgileriGetir;
        private TabPage Bilgilerim;
        private TextBox txt_adSoyad;
        private TextBox txt_eposta;
        
        private Label label19;
        private Label label18;
        private Label label17;
        private Button btn_guncelle;
        private TextBox txtsfr;
        private TabPage tabPage1;
        private Label label20;
        private DataGridView data_feedbackListe;
        private Button btn_feedbackListe;
    }
}