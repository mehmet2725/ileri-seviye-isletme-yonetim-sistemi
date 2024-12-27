namespace ileri_seviye_depo_stoğu_projesi
{
    partial class SiparisDuzenleForm
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
            lblMusteriId = new Label();
            txtMusteriId = new TextBox();
            lblToplamTutar = new Label();
            txtToplamTutar = new TextBox();
            lblSiparisDurumu = new Label();
            cmbSiparisDurumu = new ComboBox();
            btnKaydet = new Button();
            btnIptal = new Button();
            SuspendLayout();
            // 
            // lblMusteriId
            // 
            lblMusteriId.AutoSize = true;
            lblMusteriId.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblMusteriId.Location = new Point(21, 43);
            lblMusteriId.Name = "lblMusteriId";
            lblMusteriId.Size = new Size(105, 25);
            lblMusteriId.TabIndex = 0;
            lblMusteriId.Text = "Müşteri ID";
            // 
            // txtMusteriId
            // 
            txtMusteriId.Location = new Point(178, 45);
            txtMusteriId.Name = "txtMusteriId";
            txtMusteriId.Size = new Size(226, 23);
            txtMusteriId.TabIndex = 1;
            // 
            // lblToplamTutar
            // 
            lblToplamTutar.AutoSize = true;
            lblToplamTutar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblToplamTutar.Location = new Point(21, 80);
            lblToplamTutar.Name = "lblToplamTutar";
            lblToplamTutar.Size = new Size(129, 25);
            lblToplamTutar.TabIndex = 0;
            lblToplamTutar.Text = "Toplam Tutar";
            // 
            // txtToplamTutar
            // 
            txtToplamTutar.Location = new Point(178, 82);
            txtToplamTutar.Name = "txtToplamTutar";
            txtToplamTutar.Size = new Size(226, 23);
            txtToplamTutar.TabIndex = 1;
            // 
            // lblSiparisDurumu
            // 
            lblSiparisDurumu.AutoSize = true;
            lblSiparisDurumu.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblSiparisDurumu.Location = new Point(21, 127);
            lblSiparisDurumu.Name = "lblSiparisDurumu";
            lblSiparisDurumu.Size = new Size(151, 25);
            lblSiparisDurumu.TabIndex = 2;
            lblSiparisDurumu.Text = "Sipariş Durumu";
            // 
            // cmbSiparisDurumu
            // 
            cmbSiparisDurumu.FormattingEnabled = true;
            cmbSiparisDurumu.Location = new Point(178, 129);
            cmbSiparisDurumu.Name = "cmbSiparisDurumu";
            cmbSiparisDurumu.Size = new Size(247, 23);
            cmbSiparisDurumu.TabIndex = 3;
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = Color.Lime;
            btnKaydet.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnKaydet.Location = new Point(227, 213);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(138, 56);
            btnKaydet.TabIndex = 4;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnIptal
            // 
            btnIptal.BackColor = Color.Red;
            btnIptal.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnIptal.Location = new Point(398, 213);
            btnIptal.Name = "btnIptal";
            btnIptal.Size = new Size(138, 56);
            btnIptal.TabIndex = 5;
            btnIptal.Text = "İptal";
            btnIptal.UseVisualStyleBackColor = false;
            btnIptal.Click += btnIptal_Click;
            // 
            // SiparisDuzenleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(692, 361);
            Controls.Add(btnIptal);
            Controls.Add(btnKaydet);
            Controls.Add(cmbSiparisDurumu);
            Controls.Add(lblSiparisDurumu);
            Controls.Add(txtToplamTutar);
            Controls.Add(lblToplamTutar);
            Controls.Add(txtMusteriId);
            Controls.Add(lblMusteriId);
            Name = "SiparisDuzenleForm";
            Text = "SiparisDuzenleForm";
            Load += SiparisDuzenleForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMusteriId;
        private TextBox txtMusteriId;
        private Label lblToplamTutar;
        private TextBox txtToplamTutar;
        private Label lblSiparisDurumu;
        private ComboBox cmbSiparisDurumu;
        private Button btnKaydet;
        private Button btnIptal;
    }
}