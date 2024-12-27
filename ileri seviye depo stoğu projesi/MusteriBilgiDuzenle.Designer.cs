namespace ileri_seviye_depo_stoğu_projesi
{
    partial class MusteriBilgiDuzenle
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtAdSoyad = new TextBox();
            txtTelefon = new TextBox();
            txtEposta = new TextBox();
            txtAdres = new TextBox();
            txtBorcDurumu = new TextBox();
            txtToplamAlacak = new TextBox();
            btnKaydet = new Button();
            btnIptal = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label1.Location = new Point(31, 26);
            label1.Name = "label1";
            label1.Size = new Size(97, 25);
            label1.TabIndex = 0;
            label1.Text = "Ad Soyad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label2.Location = new Point(31, 77);
            label2.Name = "label2";
            label2.Size = new Size(77, 25);
            label2.TabIndex = 0;
            label2.Text = "Telefon";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label3.Location = new Point(31, 126);
            label3.Name = "label3";
            label3.Size = new Size(78, 25);
            label3.TabIndex = 0;
            label3.Text = "E-Posta";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label4.Location = new Point(31, 173);
            label4.Name = "label4";
            label4.Size = new Size(63, 25);
            label4.TabIndex = 0;
            label4.Text = "Adres";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label5.Location = new Point(31, 220);
            label5.Name = "label5";
            label5.Size = new Size(133, 25);
            label5.TabIndex = 0;
            label5.Text = "Borç Durumu";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label6.Location = new Point(31, 276);
            label6.Name = "label6";
            label6.Size = new Size(140, 25);
            label6.TabIndex = 0;
            label6.Text = "Toplam Alacak";
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(202, 31);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(194, 23);
            txtAdSoyad.TabIndex = 1;
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(202, 82);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(194, 23);
            txtTelefon.TabIndex = 1;
            // 
            // txtEposta
            // 
            txtEposta.Location = new Point(202, 131);
            txtEposta.Name = "txtEposta";
            txtEposta.Size = new Size(194, 23);
            txtEposta.TabIndex = 1;
            // 
            // txtAdres
            // 
            txtAdres.Location = new Point(202, 175);
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(194, 23);
            txtAdres.TabIndex = 1;
            // 
            // txtBorcDurumu
            // 
            txtBorcDurumu.Location = new Point(202, 222);
            txtBorcDurumu.Name = "txtBorcDurumu";
            txtBorcDurumu.Size = new Size(194, 23);
            txtBorcDurumu.TabIndex = 1;
            // 
            // txtToplamAlacak
            // 
            txtToplamAlacak.Location = new Point(202, 278);
            txtToplamAlacak.Name = "txtToplamAlacak";
            txtToplamAlacak.Size = new Size(194, 23);
            txtToplamAlacak.TabIndex = 1;
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = Color.FromArgb(0, 192, 0);
            btnKaydet.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnKaydet.Location = new Point(280, 329);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(116, 54);
            btnKaydet.TabIndex = 2;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnIptal
            // 
            btnIptal.BackColor = Color.Red;
            btnIptal.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnIptal.Location = new Point(422, 329);
            btnIptal.Name = "btnIptal";
            btnIptal.Size = new Size(116, 54);
            btnIptal.TabIndex = 2;
            btnIptal.Text = "İptal";
            btnIptal.UseVisualStyleBackColor = false;
            btnIptal.Click += btnIptal_Click;
            // 
            // MusteriBilgiDuzenle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnIptal);
            Controls.Add(btnKaydet);
            Controls.Add(txtToplamAlacak);
            Controls.Add(txtBorcDurumu);
            Controls.Add(txtAdres);
            Controls.Add(txtEposta);
            Controls.Add(txtTelefon);
            Controls.Add(txtAdSoyad);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MusteriBilgiDuzenle";
            Text = "MusteriBilgiDuzenle";
            Load += MusteriBilgiDuzenle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtAdSoyad;
        private TextBox txtTelefon;
        private TextBox txtEposta;
        private TextBox txtAdres;
        private TextBox txtBorcDurumu;
        private TextBox txtToplamAlacak;
        private Button btnKaydet;
        private Button btnIptal;
    }
}