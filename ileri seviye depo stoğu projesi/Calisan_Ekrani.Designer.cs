namespace ileri_seviye_depo_stoğu_projesi
{
    partial class Calisan_Ekrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calisan_Ekrani));
            data_stokBilgi = new DataGridView();
            label1 = new Label();
            label3 = new Label();
            data_musteriBilgi = new DataGridView();
            data_siparisBilgi = new DataGridView();
            label2 = new Label();
            data_vardiyaSaat = new DataGridView();
            label4 = new Label();
            btn_calismaVeri = new Button();
            btn_SiparisBilgileri = new Button();
            btn_musteriVeri = new Button();
            btn_StokBilgileri = new Button();
            btn_geri = new Button();
            lblYetkiSeviyesi = new Label();
            ((System.ComponentModel.ISupportInitialize)data_stokBilgi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)data_musteriBilgi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)data_siparisBilgi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)data_vardiyaSaat).BeginInit();
            SuspendLayout();
            // 
            // data_stokBilgi
            // 
            data_stokBilgi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_stokBilgi.Location = new Point(701, 500);
            data_stokBilgi.Name = "data_stokBilgi";
            data_stokBilgi.Size = new Size(311, 238);
            data_stokBilgi.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            label1.Location = new Point(701, 436);
            label1.Name = "label1";
            label1.Size = new Size(142, 30);
            label1.TabIndex = 1;
            label1.Text = "Stok durumu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ActiveCaption;
            label3.Location = new Point(701, 75);
            label3.Name = "label3";
            label3.Size = new Size(171, 30);
            label3.TabIndex = 6;
            label3.Text = "Müşteri Bilgileri";
            // 
            // data_musteriBilgi
            // 
            data_musteriBilgi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_musteriBilgi.Location = new Point(689, 122);
            data_musteriBilgi.Name = "data_musteriBilgi";
            data_musteriBilgi.Size = new Size(323, 238);
            data_musteriBilgi.TabIndex = 5;
            // 
            // data_siparisBilgi
            // 
            data_siparisBilgi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_siparisBilgi.Location = new Point(146, 500);
            data_siparisBilgi.Name = "data_siparisBilgi";
            data_siparisBilgi.Size = new Size(408, 238);
            data_siparisBilgi.TabIndex = 7;
            data_siparisBilgi.CellClick += data_siparisBilgi_CellClick;
            data_siparisBilgi.CellEndEdit += data_siparisBilgi_CellEndEdit;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ActiveCaption;
            label2.Location = new Point(189, 436);
            label2.Name = "label2";
            label2.Size = new Size(160, 30);
            label2.TabIndex = 6;
            label2.Text = "Sipariş Bilgileri";
            // 
            // data_vardiyaSaat
            // 
            data_vardiyaSaat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_vardiyaSaat.Location = new Point(160, 122);
            data_vardiyaSaat.Name = "data_vardiyaSaat";
            data_vardiyaSaat.Size = new Size(377, 238);
            data_vardiyaSaat.TabIndex = 5;
            data_vardiyaSaat.CellClick += data_vardiyaSaat_CellClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ActiveCaption;
            label4.Location = new Point(189, 75);
            label4.Name = "label4";
            label4.Size = new Size(341, 30);
            label4.TabIndex = 6;
            label4.Text = "Çalışma Saatleri ve Vardiya Bilgisi";
            // 
            // btn_calismaVeri
            // 
            btn_calismaVeri.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btn_calismaVeri.ForeColor = Color.Black;
            btn_calismaVeri.Location = new Point(12, 122);
            btn_calismaVeri.Name = "btn_calismaVeri";
            btn_calismaVeri.Size = new Size(142, 60);
            btn_calismaVeri.TabIndex = 8;
            btn_calismaVeri.Text = "Vardiya Bilgilerini Çek";
            btn_calismaVeri.UseVisualStyleBackColor = true;
            btn_calismaVeri.Click += btn_calismaVeri_Click;
            // 
            // btn_SiparisBilgileri
            // 
            btn_SiparisBilgileri.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btn_SiparisBilgileri.ForeColor = Color.Black;
            btn_SiparisBilgileri.Location = new Point(12, 500);
            btn_SiparisBilgileri.Name = "btn_SiparisBilgileri";
            btn_SiparisBilgileri.Size = new Size(128, 59);
            btn_SiparisBilgileri.TabIndex = 9;
            btn_SiparisBilgileri.Text = "Sipariş Bilgilerini Çek";
            btn_SiparisBilgileri.UseVisualStyleBackColor = true;
            btn_SiparisBilgileri.Click += btn_SiparisBilgileri_Click;
            // 
            // btn_musteriVeri
            // 
            btn_musteriVeri.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btn_musteriVeri.ForeColor = Color.Black;
            btn_musteriVeri.Location = new Point(543, 122);
            btn_musteriVeri.Name = "btn_musteriVeri";
            btn_musteriVeri.Size = new Size(140, 60);
            btn_musteriVeri.TabIndex = 10;
            btn_musteriVeri.Text = "Müşteri Bilgilerini Çek";
            btn_musteriVeri.UseVisualStyleBackColor = true;
            // 
            // btn_StokBilgileri
            // 
            btn_StokBilgileri.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btn_StokBilgileri.ForeColor = Color.Black;
            btn_StokBilgileri.Location = new Point(560, 500);
            btn_StokBilgileri.Name = "btn_StokBilgileri";
            btn_StokBilgileri.Size = new Size(135, 59);
            btn_StokBilgileri.TabIndex = 11;
            btn_StokBilgileri.Text = "Stok Bilgilerini Çek";
            btn_StokBilgileri.UseVisualStyleBackColor = true;
            // 
            // btn_geri
            // 
            btn_geri.BackColor = SystemColors.ControlLight;
            btn_geri.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btn_geri.ForeColor = SystemColors.ActiveCaptionText;
            btn_geri.Location = new Point(41, 21);
            btn_geri.Name = "btn_geri";
            btn_geri.Size = new Size(81, 29);
            btn_geri.TabIndex = 12;
            btn_geri.Text = "Geri";
            btn_geri.UseVisualStyleBackColor = false;
            // 
            // lblYetkiSeviyesi
            // 
            lblYetkiSeviyesi.AutoSize = true;
            lblYetkiSeviyesi.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblYetkiSeviyesi.Location = new Point(829, 25);
            lblYetkiSeviyesi.Name = "lblYetkiSeviyesi";
            lblYetkiSeviyesi.Size = new Size(59, 25);
            lblYetkiSeviyesi.TabIndex = 13;
            lblYetkiSeviyesi.Text = "labell";
            // 
            // Calisan_Ekrani
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1021, 769);
            Controls.Add(lblYetkiSeviyesi);
            Controls.Add(btn_geri);
            Controls.Add(btn_StokBilgileri);
            Controls.Add(btn_musteriVeri);
            Controls.Add(btn_SiparisBilgileri);
            Controls.Add(btn_calismaVeri);
            Controls.Add(data_siparisBilgi);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(data_vardiyaSaat);
            Controls.Add(data_musteriBilgi);
            Controls.Add(label1);
            Controls.Add(data_stokBilgi);
            ForeColor = SystemColors.ActiveCaption;
            Name = "Calisan_Ekrani";
            Text = "Calisan_Ekrani";
            Load += Calisan_Ekrani_Load;
            ((System.ComponentModel.ISupportInitialize)data_stokBilgi).EndInit();
            ((System.ComponentModel.ISupportInitialize)data_musteriBilgi).EndInit();
            ((System.ComponentModel.ISupportInitialize)data_siparisBilgi).EndInit();
            ((System.ComponentModel.ISupportInitialize)data_vardiyaSaat).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView data_stokBilgi;
        private Label label1;
        private Label label3;
        private DataGridView data_musteriBilgi;
        private DataGridView data_siparisBilgi;
        private Label label2;
        private DataGridView data_vardiyaSaat;
        private Label label4;
        private Button btn_calismaVeri;
        private Button btn_SiparisBilgileri;
        private Button btn_musteriVeri;
        private Button btn_StokBilgileri;
        private Button btn_geri;
        private Label lblYetkiSeviyesi;
    }
}