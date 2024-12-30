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
            btn_vardiyaVeri = new Button();
            btn_calisanVeri = new Button();
            label2 = new Label();
            data_vardiyaIzin = new DataGridView();
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
            tab_yetkiErisim = new TabPage();
            btn_yetkiErisimVeri = new Button();
            data_yetkiErisim = new DataGridView();
            label8 = new Label();
            tab_logKaydı = new TabPage();
            btn_logVeri = new Button();
            data_logKaydi = new DataGridView();
            label7 = new Label();
            tab_siparisTakip = new TabPage();
            btn_siparisTakipVeri = new Button();
            data_genelSiparis = new DataGridView();
            label9 = new Label();
            tab_kayit = new TabPage();
            radio_yonetici = new RadioButton();
            radio_calisan = new RadioButton();
            radio_musteri = new RadioButton();
            btn_kayit = new Button();
            txt_ePosta = new TextBox();
            txt_sifre = new TextBox();
            txt_telNo = new TextBox();
            label13 = new Label();
            txt_KAdi = new TextBox();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            tab_siparisOlustur = new TabPage();
            btn_geri = new Button();
            tabcontrol.SuspendLayout();
            tab_calisanYonetim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)data_vardiyaIzin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)data_calisan).BeginInit();
            tab_musteriSiparisYonetim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)data_muteriSiparis).BeginInit();
            ((System.ComponentModel.ISupportInitialize)data_musteri).BeginInit();
            tab_stokSatis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)data_satisRapor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)data_Stok).BeginInit();
            tab_yetkiErisim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)data_yetkiErisim).BeginInit();
            tab_logKaydı.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)data_logKaydi).BeginInit();
            tab_siparisTakip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)data_genelSiparis).BeginInit();
            tab_kayit.SuspendLayout();
            SuspendLayout();
            // 
            // tabcontrol
            // 
            tabcontrol.Controls.Add(tab_calisanYonetim);
            tabcontrol.Controls.Add(tab_musteriSiparisYonetim);
            tabcontrol.Controls.Add(tab_stokSatis);
            tabcontrol.Controls.Add(tab_yetkiErisim);
            tabcontrol.Controls.Add(tab_logKaydı);
            tabcontrol.Controls.Add(tab_siparisTakip);
            tabcontrol.Controls.Add(tab_kayit);
            tabcontrol.Controls.Add(tab_siparisOlustur);
            tabcontrol.Location = new Point(93, 55);
            tabcontrol.Name = "tabcontrol";
            tabcontrol.SelectedIndex = 0;
            tabcontrol.Size = new Size(926, 563);
            tabcontrol.TabIndex = 0;
            // 
            // tab_calisanYonetim
            // 
            tab_calisanYonetim.Controls.Add(btn_vardiyaVeri);
            tab_calisanYonetim.Controls.Add(btn_calisanVeri);
            tab_calisanYonetim.Controls.Add(label2);
            tab_calisanYonetim.Controls.Add(data_vardiyaIzin);
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
            // btn_vardiyaVeri
            // 
            btn_vardiyaVeri.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btn_vardiyaVeri.ForeColor = Color.Black;
            btn_vardiyaVeri.Location = new Point(772, 399);
            btn_vardiyaVeri.Name = "btn_vardiyaVeri";
            btn_vardiyaVeri.Size = new Size(84, 32);
            btn_vardiyaVeri.TabIndex = 10;
            btn_vardiyaVeri.Text = "Veri Çek";
            btn_vardiyaVeri.UseVisualStyleBackColor = true;
            // 
            // btn_calisanVeri
            // 
            btn_calisanVeri.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btn_calisanVeri.ForeColor = Color.Black;
            btn_calisanVeri.Location = new Point(340, 399);
            btn_calisanVeri.Name = "btn_calisanVeri";
            btn_calisanVeri.Size = new Size(84, 32);
            btn_calisanVeri.TabIndex = 9;
            btn_calisanVeri.Text = "Veri Çek";
            btn_calisanVeri.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(478, 75);
            label2.Name = "label2";
            label2.Size = new Size(280, 25);
            label2.TabIndex = 3;
            label2.Text = "Çalışan Vardiya ve İzin Bilgileri";
            // 
            // data_vardiyaIzin
            // 
            data_vardiyaIzin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_vardiyaIzin.Location = new Point(478, 115);
            data_vardiyaIzin.Name = "data_vardiyaIzin";
            data_vardiyaIzin.Size = new Size(378, 278);
            data_vardiyaIzin.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(46, 75);
            label1.Name = "label1";
            label1.Size = new Size(146, 25);
            label1.TabIndex = 1;
            label1.Text = "Çalışan Bilgileri";
            // 
            // data_calisan
            // 
            data_calisan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_calisan.Location = new Point(46, 115);
            data_calisan.Name = "data_calisan";
            data_calisan.Size = new Size(378, 278);
            data_calisan.TabIndex = 0;
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
            btn_siparisVeri.Location = new Point(701, 391);
            btn_siparisVeri.Name = "btn_siparisVeri";
            btn_siparisVeri.Size = new Size(84, 32);
            btn_siparisVeri.TabIndex = 10;
            btn_siparisVeri.Text = "Veri Çek";
            btn_siparisVeri.UseVisualStyleBackColor = true;
            // 
            // btn_musteriVeri
            // 
            btn_musteriVeri.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btn_musteriVeri.ForeColor = Color.Black;
            btn_musteriVeri.Location = new Point(284, 391);
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
            data_muteriSiparis.Size = new Size(309, 284);
            data_muteriSiparis.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(476, 43);
            label4.Name = "label4";
            label4.Size = new Size(143, 25);
            label4.TabIndex = 2;
            label4.Text = "Sipariş Bilgileri";
            // 
            // data_musteri
            // 
            data_musteri.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_musteri.Location = new Point(59, 101);
            data_musteri.Name = "data_musteri";
            data_musteri.Size = new Size(309, 284);
            data_musteri.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(59, 43);
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
            // 
            // data_satisRapor
            // 
            data_satisRapor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_satisRapor.Location = new Point(496, 121);
            data_satisRapor.Name = "data_satisRapor";
            data_satisRapor.Size = new Size(309, 284);
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
            data_Stok.Location = new Point(79, 121);
            data_Stok.Name = "data_Stok";
            data_Stok.Size = new Size(309, 284);
            data_Stok.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.Location = new Point(79, 63);
            label6.Name = "label6";
            label6.Size = new Size(125, 25);
            label6.TabIndex = 4;
            label6.Text = "Stok Bilgileri";
            // 
            // tab_yetkiErisim
            // 
            tab_yetkiErisim.Controls.Add(btn_yetkiErisimVeri);
            tab_yetkiErisim.Controls.Add(data_yetkiErisim);
            tab_yetkiErisim.Controls.Add(label8);
            tab_yetkiErisim.Location = new Point(4, 24);
            tab_yetkiErisim.Name = "tab_yetkiErisim";
            tab_yetkiErisim.Padding = new Padding(3);
            tab_yetkiErisim.Size = new Size(918, 535);
            tab_yetkiErisim.TabIndex = 3;
            tab_yetkiErisim.Text = "Yetki ve Erişim Kontrolü";
            tab_yetkiErisim.UseVisualStyleBackColor = true;
            // 
            // btn_yetkiErisimVeri
            // 
            btn_yetkiErisimVeri.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            btn_yetkiErisimVeri.ForeColor = Color.Black;
            btn_yetkiErisimVeri.Location = new Point(688, 468);
            btn_yetkiErisimVeri.Name = "btn_yetkiErisimVeri";
            btn_yetkiErisimVeri.Size = new Size(104, 48);
            btn_yetkiErisimVeri.TabIndex = 10;
            btn_yetkiErisimVeri.Text = "Veri Çek";
            btn_yetkiErisimVeri.UseVisualStyleBackColor = true;
            // 
            // data_yetkiErisim
            // 
            data_yetkiErisim.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_yetkiErisim.Location = new Point(74, 125);
            data_yetkiErisim.Name = "data_yetkiErisim";
            data_yetkiErisim.Size = new Size(718, 337);
            data_yetkiErisim.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label8.Location = new Point(74, 69);
            label8.Name = "label8";
            label8.Size = new Size(318, 25);
            label8.TabIndex = 4;
            label8.Text = "Çalışan Yetkileri ve Erişim Kontrolü";
            // 
            // tab_logKaydı
            // 
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
            // btn_logVeri
            // 
            btn_logVeri.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            btn_logVeri.ForeColor = Color.Black;
            btn_logVeri.Location = new Point(714, 472);
            btn_logVeri.Name = "btn_logVeri";
            btn_logVeri.Size = new Size(104, 48);
            btn_logVeri.TabIndex = 11;
            btn_logVeri.Text = "Veri Çek";
            btn_logVeri.UseVisualStyleBackColor = true;
            // 
            // data_logKaydi
            // 
            data_logKaydi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_logKaydi.Location = new Point(100, 129);
            data_logKaydi.Name = "data_logKaydi";
            data_logKaydi.Size = new Size(718, 337);
            data_logKaydi.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label7.Location = new Point(100, 69);
            label7.Name = "label7";
            label7.Size = new Size(123, 25);
            label7.TabIndex = 6;
            label7.Text = "Log Kayıtları";
            // 
            // tab_siparisTakip
            // 
            tab_siparisTakip.Controls.Add(btn_siparisTakipVeri);
            tab_siparisTakip.Controls.Add(data_genelSiparis);
            tab_siparisTakip.Controls.Add(label9);
            tab_siparisTakip.Location = new Point(4, 24);
            tab_siparisTakip.Name = "tab_siparisTakip";
            tab_siparisTakip.Padding = new Padding(3);
            tab_siparisTakip.Size = new Size(918, 535);
            tab_siparisTakip.TabIndex = 5;
            tab_siparisTakip.Text = "Sipariş Takibi";
            tab_siparisTakip.UseVisualStyleBackColor = true;
            // 
            // btn_siparisTakipVeri
            // 
            btn_siparisTakipVeri.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            btn_siparisTakipVeri.ForeColor = Color.Black;
            btn_siparisTakipVeri.Location = new Point(675, 473);
            btn_siparisTakipVeri.Name = "btn_siparisTakipVeri";
            btn_siparisTakipVeri.Size = new Size(104, 48);
            btn_siparisTakipVeri.TabIndex = 12;
            btn_siparisTakipVeri.Text = "Veri Çek";
            btn_siparisTakipVeri.UseVisualStyleBackColor = true;
            // 
            // data_genelSiparis
            // 
            data_genelSiparis.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_genelSiparis.Location = new Point(67, 105);
            data_genelSiparis.Name = "data_genelSiparis";
            data_genelSiparis.Size = new Size(712, 362);
            data_genelSiparis.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label9.Location = new Point(67, 45);
            label9.Name = "label9";
            label9.Size = new Size(128, 25);
            label9.TabIndex = 0;
            label9.Text = "Sipariş Takibi";
            // 
            // tab_kayit
            // 
            tab_kayit.Controls.Add(radio_yonetici);
            tab_kayit.Controls.Add(radio_calisan);
            tab_kayit.Controls.Add(radio_musteri);
            tab_kayit.Controls.Add(btn_kayit);
            tab_kayit.Controls.Add(txt_ePosta);
            tab_kayit.Controls.Add(txt_sifre);
            tab_kayit.Controls.Add(txt_telNo);
            tab_kayit.Controls.Add(label13);
            tab_kayit.Controls.Add(txt_KAdi);
            tab_kayit.Controls.Add(label12);
            tab_kayit.Controls.Add(label11);
            tab_kayit.Controls.Add(label10);
            tab_kayit.Location = new Point(4, 24);
            tab_kayit.Name = "tab_kayit";
            tab_kayit.Padding = new Padding(3);
            tab_kayit.Size = new Size(918, 535);
            tab_kayit.TabIndex = 6;
            tab_kayit.Text = "Kayıt Oluştur";
            tab_kayit.UseVisualStyleBackColor = true;
            // 
            // radio_yonetici
            // 
            radio_yonetici.AutoSize = true;
            radio_yonetici.Location = new Point(542, 282);
            radio_yonetici.Name = "radio_yonetici";
            radio_yonetici.Size = new Size(67, 19);
            radio_yonetici.TabIndex = 7;
            radio_yonetici.TabStop = true;
            radio_yonetici.Text = "Yönetici";
            radio_yonetici.UseVisualStyleBackColor = true;
            // 
            // radio_calisan
            // 
            radio_calisan.AutoSize = true;
            radio_calisan.Location = new Point(430, 282);
            radio_calisan.Name = "radio_calisan";
            radio_calisan.Size = new Size(63, 19);
            radio_calisan.TabIndex = 6;
            radio_calisan.TabStop = true;
            radio_calisan.Text = "Çalışan";
            radio_calisan.UseVisualStyleBackColor = true;
            // 
            // radio_musteri
            // 
            radio_musteri.AutoSize = true;
            radio_musteri.Location = new Point(323, 282);
            radio_musteri.Name = "radio_musteri";
            radio_musteri.Size = new Size(65, 19);
            radio_musteri.TabIndex = 5;
            radio_musteri.TabStop = true;
            radio_musteri.Text = "Müşteri";
            radio_musteri.UseVisualStyleBackColor = true;
            radio_musteri.CheckedChanged += radio_musteri_CheckedChanged;
            // 
            // btn_kayit
            // 
            btn_kayit.Location = new Point(542, 319);
            btn_kayit.Name = "btn_kayit";
            btn_kayit.Size = new Size(75, 23);
            btn_kayit.TabIndex = 4;
            btn_kayit.Text = "Kaydet";
            btn_kayit.UseVisualStyleBackColor = true;
            // 
            // txt_ePosta
            // 
            txt_ePosta.Location = new Point(430, 233);
            txt_ePosta.Name = "txt_ePosta";
            txt_ePosta.Size = new Size(100, 23);
            txt_ePosta.TabIndex = 3;
            // 
            // txt_sifre
            // 
            txt_sifre.Location = new Point(430, 130);
            txt_sifre.Name = "txt_sifre";
            txt_sifre.Size = new Size(100, 23);
            txt_sifre.TabIndex = 3;
            // 
            // txt_telNo
            // 
            txt_telNo.Location = new Point(430, 171);
            txt_telNo.Name = "txt_telNo";
            txt_telNo.Size = new Size(100, 23);
            txt_telNo.TabIndex = 2;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(323, 241);
            label13.Name = "label13";
            label13.Size = new Size(47, 15);
            label13.TabIndex = 1;
            label13.Text = "E-Posta";
            // 
            // txt_KAdi
            // 
            txt_KAdi.Location = new Point(430, 68);
            txt_KAdi.Name = "txt_KAdi";
            txt_KAdi.Size = new Size(100, 23);
            txt_KAdi.TabIndex = 2;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(323, 179);
            label12.Name = "label12";
            label12.Size = new Size(100, 15);
            label12.TabIndex = 0;
            label12.Text = "Telefon Numarası";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(323, 138);
            label11.Name = "label11";
            label11.Size = new Size(30, 15);
            label11.TabIndex = 1;
            label11.Text = "Şifre";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(323, 76);
            label10.Name = "label10";
            label10.Size = new Size(73, 15);
            label10.TabIndex = 0;
            label10.Text = "Kullanıcı Adı";
            // 
            // tab_siparisOlustur
            // 
            tab_siparisOlustur.Location = new Point(4, 24);
            tab_siparisOlustur.Name = "tab_siparisOlustur";
            tab_siparisOlustur.Padding = new Padding(3);
            tab_siparisOlustur.Size = new Size(918, 535);
            tab_siparisOlustur.TabIndex = 7;
            tab_siparisOlustur.Text = "Sipariş Oluştur";
            tab_siparisOlustur.UseVisualStyleBackColor = true;
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
            tabcontrol.ResumeLayout(false);
            tab_calisanYonetim.ResumeLayout(false);
            tab_calisanYonetim.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)data_vardiyaIzin).EndInit();
            ((System.ComponentModel.ISupportInitialize)data_calisan).EndInit();
            tab_musteriSiparisYonetim.ResumeLayout(false);
            tab_musteriSiparisYonetim.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)data_muteriSiparis).EndInit();
            ((System.ComponentModel.ISupportInitialize)data_musteri).EndInit();
            tab_stokSatis.ResumeLayout(false);
            tab_stokSatis.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)data_satisRapor).EndInit();
            ((System.ComponentModel.ISupportInitialize)data_Stok).EndInit();
            tab_yetkiErisim.ResumeLayout(false);
            tab_yetkiErisim.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)data_yetkiErisim).EndInit();
            tab_logKaydı.ResumeLayout(false);
            tab_logKaydı.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)data_logKaydi).EndInit();
            tab_siparisTakip.ResumeLayout(false);
            tab_siparisTakip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)data_genelSiparis).EndInit();
            tab_kayit.ResumeLayout(false);
            tab_kayit.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabcontrol;
        private TabPage tab_calisanYonetim;
        private TabPage tab_musteriSiparisYonetim;
        private TabPage tab_stokSatis;
        private TabPage tab_yetkiErisim;
        private TabPage tab_logKaydı;
        private TabPage tab_siparisTakip;
        private DataGridView data_calisan;
        private Label label2;
        private DataGridView data_vardiyaIzin;
        private Label label1;
        private Label label3;
        private DataGridView data_musteri;
        private DataGridView data_muteriSiparis;
        private Label label4;
        private DataGridView data_satisRapor;
        private Label label5;
        private DataGridView data_Stok;
        private Label label6;
        private DataGridView data_yetkiErisim;
        private Label label8;
        private DataGridView data_logKaydi;
        private Label label7;
        private DataGridView data_genelSiparis;
        private Label label9;
        private Button btn_vardiyaVeri;
        private Button btn_calisanVeri;
        private Button btn_siparisVeri;
        private Button btn_musteriVeri;
        private Button btn_stokVeri;
        private Button btn_satisVeri;
        private Button btn_yetkiErisimVeri;
        private Button btn_logVeri;
        private Button btn_siparisTakipVeri;
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
        private TextBox txt_telNo;
        private Label label13;
        private Label label12;
        private TabPage tab_siparisOlustur;
    }
}