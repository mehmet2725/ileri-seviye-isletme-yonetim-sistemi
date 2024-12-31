namespace ileri_seviye_depo_stoğu_projesi
{
    partial class SiparisEkle
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
            label1 = new Label();
            cmbMusteriSecim = new ComboBox();
            label2 = new Label();
            cmbUrunSecim = new ComboBox();
            label3 = new Label();
            txtStokMiktar = new TextBox();
            label4 = new Label();
            numSiparisMiktar = new NumericUpDown();
            label5 = new Label();
            txtUrunFiyat = new TextBox();
            label6 = new Label();
            txtToplamTutar = new TextBox();
            label7 = new Label();
            cmbSiparisDurumu = new ComboBox();
            btnSiparisEkle = new Button();
            btnIptal = new Button();
            btn_hesapla = new Button();
            ((System.ComponentModel.ISupportInitialize)numSiparisMiktar).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(30, 45);
            label1.Name = "label1";
            label1.Size = new Size(146, 25);
            label1.TabIndex = 0;
            label1.Text = "Müşteri Seçiniz";
            // 
            // cmbMusteriSecim
            // 
            cmbMusteriSecim.FormattingEnabled = true;
            cmbMusteriSecim.Location = new Point(221, 45);
            cmbMusteriSecim.Name = "cmbMusteriSecim";
            cmbMusteriSecim.Size = new Size(207, 23);
            cmbMusteriSecim.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(30, 99);
            label2.Name = "label2";
            label2.Size = new Size(124, 25);
            label2.TabIndex = 0;
            label2.Text = "Ürün Seçiniz";
            // 
            // cmbUrunSecim
            // 
            cmbUrunSecim.FormattingEnabled = true;
            cmbUrunSecim.Location = new Point(221, 99);
            cmbUrunSecim.Name = "cmbUrunSecim";
            cmbUrunSecim.Size = new Size(207, 23);
            cmbUrunSecim.TabIndex = 1;
            cmbUrunSecim.SelectedIndexChanged += cmbUrunSecim_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(30, 156);
            label3.Name = "label3";
            label3.Size = new Size(122, 25);
            label3.TabIndex = 0;
            label3.Text = "Stok Miktarı";
            // 
            // txtStokMiktar
            // 
            txtStokMiktar.Location = new Point(221, 161);
            txtStokMiktar.Name = "txtStokMiktar";
            txtStokMiktar.Size = new Size(207, 23);
            txtStokMiktar.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(30, 222);
            label4.Name = "label4";
            label4.Size = new Size(140, 25);
            label4.TabIndex = 0;
            label4.Text = "Sipariş Miktarı";
            // 
            // numSiparisMiktar
            // 
            numSiparisMiktar.Location = new Point(221, 224);
            numSiparisMiktar.Name = "numSiparisMiktar";
            numSiparisMiktar.Size = new Size(120, 23);
            numSiparisMiktar.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.Location = new Point(30, 283);
            label5.Name = "label5";
            label5.Size = new Size(110, 25);
            label5.TabIndex = 0;
            label5.Text = "Ürün Fiyatı";
            // 
            // txtUrunFiyat
            // 
            txtUrunFiyat.Location = new Point(221, 285);
            txtUrunFiyat.Name = "txtUrunFiyat";
            txtUrunFiyat.Size = new Size(207, 23);
            txtUrunFiyat.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.Location = new Point(30, 332);
            label6.Name = "label6";
            label6.Size = new Size(129, 25);
            label6.TabIndex = 0;
            label6.Text = "Toplam Tutar";
            // 
            // txtToplamTutar
            // 
            txtToplamTutar.Location = new Point(221, 334);
            txtToplamTutar.Name = "txtToplamTutar";
            txtToplamTutar.Size = new Size(207, 23);
            txtToplamTutar.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label7.Location = new Point(30, 400);
            label7.Name = "label7";
            label7.Size = new Size(151, 25);
            label7.TabIndex = 0;
            label7.Text = "Sipariş Durumu";
            // 
            // cmbSiparisDurumu
            // 
            cmbSiparisDurumu.FormattingEnabled = true;
            cmbSiparisDurumu.Location = new Point(221, 400);
            cmbSiparisDurumu.Name = "cmbSiparisDurumu";
            cmbSiparisDurumu.Size = new Size(207, 23);
            cmbSiparisDurumu.TabIndex = 1;
            // 
            // btnSiparisEkle
            // 
            btnSiparisEkle.BackColor = Color.Lime;
            btnSiparisEkle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSiparisEkle.Location = new Point(298, 449);
            btnSiparisEkle.Name = "btnSiparisEkle";
            btnSiparisEkle.Size = new Size(130, 50);
            btnSiparisEkle.TabIndex = 4;
            btnSiparisEkle.Text = "Kaydet";
            btnSiparisEkle.UseVisualStyleBackColor = false;
            btnSiparisEkle.Click += btnSiparisEkle_Click;
            // 
            // btnIptal
            // 
            btnIptal.BackColor = Color.Red;
            btnIptal.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnIptal.Location = new Point(446, 449);
            btnIptal.Name = "btnIptal";
            btnIptal.Size = new Size(130, 50);
            btnIptal.TabIndex = 4;
            btnIptal.Text = "İptal";
            btnIptal.UseVisualStyleBackColor = false;
            btnIptal.Click += btnIptal_Click;
            // 
            // btn_hesapla
            // 
            btn_hesapla.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btn_hesapla.Location = new Point(464, 319);
            btn_hesapla.Name = "btn_hesapla";
            btn_hesapla.Size = new Size(129, 55);
            btn_hesapla.TabIndex = 5;
            btn_hesapla.Text = "Toplam Tutarı Hesapla";
            btn_hesapla.UseVisualStyleBackColor = true;
            btn_hesapla.Click += btn_hesapla_Click;
            // 
            // SiparisEkle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(860, 531);
            Controls.Add(btn_hesapla);
            Controls.Add(btnIptal);
            Controls.Add(btnSiparisEkle);
            Controls.Add(numSiparisMiktar);
            Controls.Add(txtToplamTutar);
            Controls.Add(txtUrunFiyat);
            Controls.Add(txtStokMiktar);
            Controls.Add(cmbSiparisDurumu);
            Controls.Add(cmbUrunSecim);
            Controls.Add(cmbMusteriSecim);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "SiparisEkle";
            Text = "SiparisEkle";
            Load += SiparisEkle_Load;
            ((System.ComponentModel.ISupportInitialize)numSiparisMiktar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbMusteriSecim;
        private Label label2;
        private ComboBox cmbUrunSecim;
        private Label label3;
        private TextBox txtStokMiktar;
        private Label label4;
        private NumericUpDown numSiparisMiktar;
        private Label label5;
        private TextBox txtUrunFiyat;
        private Label label6;
        private TextBox txtToplamTutar;
        private Label label7;
        private ComboBox cmbSiparisDurumu;
        private Button btnSiparisEkle;
        private Button btnIptal;
        private Button btn_hesapla;
    }
}