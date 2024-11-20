namespace ileri_seviye_depo_stoğu_projesi
{
    partial class lbll
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(lbll));
            data_stokBilgi = new DataGridView();
            label1 = new Label();
            label3 = new Label();
            data_musteriBilgi = new DataGridView();
            data_siparisBilgi = new DataGridView();
            label2 = new Label();
            data_vardiyaSaat = new DataGridView();
            label4 = new Label();
            btn_calismaVeri = new Button();
            btn_siparisVeri = new Button();
            btn_musteriVeri = new Button();
            btn_stokVeri = new Button();
            ((System.ComponentModel.ISupportInitialize)data_stokBilgi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)data_musteriBilgi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)data_siparisBilgi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)data_vardiyaSaat).BeginInit();
            SuspendLayout();
            // 
            // data_stokBilgi
            // 
            data_stokBilgi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_stokBilgi.Location = new Point(660, 450);
            data_stokBilgi.Name = "data_stokBilgi";
            data_stokBilgi.Size = new Size(285, 238);
            data_stokBilgi.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label1.Location = new Point(660, 386);
            label1.Name = "label1";
            label1.Size = new Size(122, 25);
            label1.TabIndex = 1;
            label1.Text = "Stok durumu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ActiveCaption;
            label3.Location = new Point(660, 25);
            label3.Name = "label3";
            label3.Size = new Size(147, 25);
            label3.TabIndex = 6;
            label3.Text = "Müşteri Bilgileri";
            // 
            // data_musteriBilgi
            // 
            data_musteriBilgi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_musteriBilgi.Location = new Point(660, 72);
            data_musteriBilgi.Name = "data_musteriBilgi";
            data_musteriBilgi.Size = new Size(285, 238);
            data_musteriBilgi.TabIndex = 5;
            // 
            // data_siparisBilgi
            // 
            data_siparisBilgi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_siparisBilgi.Location = new Point(148, 450);
            data_siparisBilgi.Name = "data_siparisBilgi";
            data_siparisBilgi.Size = new Size(275, 238);
            data_siparisBilgi.TabIndex = 7;
            data_siparisBilgi.CellContentClick += dataGridView3_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ActiveCaption;
            label2.Location = new Point(148, 386);
            label2.Name = "label2";
            label2.Size = new Size(137, 25);
            label2.TabIndex = 6;
            label2.Text = "Sipariş Bilgileri";
            // 
            // data_vardiyaSaat
            // 
            data_vardiyaSaat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_vardiyaSaat.Location = new Point(148, 72);
            data_vardiyaSaat.Name = "data_vardiyaSaat";
            data_vardiyaSaat.Size = new Size(285, 238);
            data_vardiyaSaat.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ActiveCaption;
            label4.Location = new Point(148, 25);
            label4.Name = "label4";
            label4.Size = new Size(297, 25);
            label4.TabIndex = 6;
            label4.Text = "Çalışma Saatleri ve Vardiya Bilgisi";
            // 
            // btn_calismaVeri
            // 
            btn_calismaVeri.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btn_calismaVeri.ForeColor = Color.Black;
            btn_calismaVeri.Location = new Point(44, 72);
            btn_calismaVeri.Name = "btn_calismaVeri";
            btn_calismaVeri.Size = new Size(84, 32);
            btn_calismaVeri.TabIndex = 8;
            btn_calismaVeri.Text = "Veri Çek";
            btn_calismaVeri.UseVisualStyleBackColor = true;
            // 
            // btn_siparisVeri
            // 
            btn_siparisVeri.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btn_siparisVeri.ForeColor = Color.Black;
            btn_siparisVeri.Location = new Point(44, 450);
            btn_siparisVeri.Name = "btn_siparisVeri";
            btn_siparisVeri.Size = new Size(84, 32);
            btn_siparisVeri.TabIndex = 9;
            btn_siparisVeri.Text = "Veri Çek";
            btn_siparisVeri.UseVisualStyleBackColor = true;
            // 
            // btn_musteriVeri
            // 
            btn_musteriVeri.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btn_musteriVeri.ForeColor = Color.Black;
            btn_musteriVeri.Location = new Point(558, 72);
            btn_musteriVeri.Name = "btn_musteriVeri";
            btn_musteriVeri.Size = new Size(84, 32);
            btn_musteriVeri.TabIndex = 10;
            btn_musteriVeri.Text = "Veri Çek";
            btn_musteriVeri.UseVisualStyleBackColor = true;
            // 
            // btn_stokVeri
            // 
            btn_stokVeri.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btn_stokVeri.ForeColor = Color.Black;
            btn_stokVeri.Location = new Point(570, 450);
            btn_stokVeri.Name = "btn_stokVeri";
            btn_stokVeri.Size = new Size(84, 32);
            btn_stokVeri.TabIndex = 11;
            btn_stokVeri.Text = "Veri Çek";
            btn_stokVeri.UseVisualStyleBackColor = true;
            // 
            // lbll
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1024, 716);
            Controls.Add(btn_stokVeri);
            Controls.Add(btn_musteriVeri);
            Controls.Add(btn_siparisVeri);
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
            Name = "lbll";
            Text = "Calisan_Ekrani";
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
        private Button btn_siparisVeri;
        private Button btn_musteriVeri;
        private Button btn_stokVeri;
    }
}