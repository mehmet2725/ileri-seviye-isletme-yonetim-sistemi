namespace ileri_seviye_depo_stoğu_projesi
{
    partial class StokDuzenle
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
            lblUrunId = new Label();
            label1 = new Label();
            txtUrunAdi = new TextBox();
            label2 = new Label();
            txtStokMiktari = new TextBox();
            label3 = new Label();
            txtFiyat = new TextBox();
            btnKaydet = new Button();
            btnIptal = new Button();
            lblSonGuncelleme = new Label();
            SuspendLayout();
            // 
            // lblUrunId
            // 
            lblUrunId.AutoSize = true;
            lblUrunId.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblUrunId.Location = new Point(12, 9);
            lblUrunId.Name = "lblUrunId";
            lblUrunId.Size = new Size(83, 32);
            lblUrunId.TabIndex = 0;
            lblUrunId.Text = "label1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(67, 91);
            label1.Name = "label1";
            label1.Size = new Size(93, 25);
            label1.TabIndex = 1;
            label1.Text = "Ürün Adı";
            // 
            // txtUrunAdi
            // 
            txtUrunAdi.Location = new Point(216, 93);
            txtUrunAdi.Name = "txtUrunAdi";
            txtUrunAdi.Size = new Size(201, 23);
            txtUrunAdi.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(67, 139);
            label2.Name = "label2";
            label2.Size = new Size(122, 25);
            label2.TabIndex = 1;
            label2.Text = "Stok Miktarı";
            // 
            // txtStokMiktari
            // 
            txtStokMiktari.Location = new Point(216, 141);
            txtStokMiktari.Name = "txtStokMiktari";
            txtStokMiktari.Size = new Size(201, 23);
            txtStokMiktari.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(67, 184);
            label3.Name = "label3";
            label3.Size = new Size(110, 25);
            label3.TabIndex = 1;
            label3.Text = "Ürün Fiyatı";
            // 
            // txtFiyat
            // 
            txtFiyat.Location = new Point(216, 186);
            txtFiyat.Name = "txtFiyat";
            txtFiyat.Size = new Size(201, 23);
            txtFiyat.TabIndex = 2;
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = Color.Lime;
            btnKaydet.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnKaydet.Location = new Point(365, 285);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(101, 51);
            btnKaydet.TabIndex = 3;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnIptal
            // 
            btnIptal.BackColor = Color.Red;
            btnIptal.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnIptal.Location = new Point(487, 285);
            btnIptal.Name = "btnIptal";
            btnIptal.Size = new Size(101, 51);
            btnIptal.TabIndex = 3;
            btnIptal.Text = "İptal";
            btnIptal.UseVisualStyleBackColor = false;
            btnIptal.Click += btnIptal_Click;
            // 
            // lblSonGuncelleme
            // 
            lblSonGuncelleme.AutoSize = true;
            lblSonGuncelleme.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblSonGuncelleme.ForeColor = Color.Maroon;
            lblSonGuncelleme.Location = new Point(642, 388);
            lblSonGuncelleme.Name = "lblSonGuncelleme";
            lblSonGuncelleme.Size = new Size(57, 21);
            lblSonGuncelleme.TabIndex = 4;
            lblSonGuncelleme.Text = "label4";
            // 
            // StokDuzenle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblSonGuncelleme);
            Controls.Add(btnIptal);
            Controls.Add(btnKaydet);
            Controls.Add(txtFiyat);
            Controls.Add(label3);
            Controls.Add(txtStokMiktari);
            Controls.Add(label2);
            Controls.Add(txtUrunAdi);
            Controls.Add(label1);
            Controls.Add(lblUrunId);
            Name = "StokDuzenle";
            Text = "StokDuzenle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUrunId;
        private Label label1;
        private TextBox txtUrunAdi;
        private Label label2;
        private TextBox txtStokMiktari;
        private Label label3;
        private TextBox txtFiyat;
        private Button btnKaydet;
        private Button btnIptal;
        private Label lblSonGuncelleme;
    }
}