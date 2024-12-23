namespace ileri_seviye_depo_stoğu_projesi
{
    partial class MusteriEkrani
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusteriEkrani));
            label1 = new Label();
            data_musteriBilgi = new DataGridView();
            data_siparisBilgi = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            txt_telNo = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txt_eposta = new TextBox();
            btn_guncelle = new Button();
            rtb_feedback = new RichTextBox();
            label6 = new Label();
            data_gecmisSiparis = new DataGridView();
            label7 = new Label();
            btn_musteriVeri = new Button();
            btn_geri = new Button();
            btn_gonder = new Button();
            btn_siparisVeri = new Button();
            btn_gecmisSiparis = new Button();
            ((System.ComponentModel.ISupportInitialize)data_musteriBilgi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)data_siparisBilgi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)data_gecmisSiparis).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 19F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(133, 49);
            label1.Name = "label1";
            label1.Size = new Size(204, 36);
            label1.TabIndex = 0;
            label1.Text = "Müşteri Bİlgileri";
            // 
            // data_musteriBilgi
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            data_musteriBilgi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            data_musteriBilgi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            data_musteriBilgi.DefaultCellStyle = dataGridViewCellStyle2;
            data_musteriBilgi.Location = new Point(47, 109);
            data_musteriBilgi.Name = "data_musteriBilgi";
            data_musteriBilgi.Size = new Size(394, 268);
            data_musteriBilgi.TabIndex = 1;
            data_musteriBilgi.CellClick += data_musteriBilgi_CellClick;
            // 
            // data_siparisBilgi
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            data_siparisBilgi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            data_siparisBilgi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            data_siparisBilgi.DefaultCellStyle = dataGridViewCellStyle4;
            data_siparisBilgi.Location = new Point(533, 109);
            data_siparisBilgi.Name = "data_siparisBilgi";
            data_siparisBilgi.Size = new Size(408, 268);
            data_siparisBilgi.TabIndex = 3;
            data_siparisBilgi.CellClick += data_siparisBilgi_CellClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 19F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ActiveCaption;
            label2.Location = new Point(643, 49);
            label2.Name = "label2";
            label2.Size = new Size(192, 36);
            label2.TabIndex = 2;
            label2.Text = "Sipariş Bilgileri";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ControlLight;
            label3.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            label3.Location = new Point(101, 588);
            label3.Name = "label3";
            label3.Size = new Size(508, 32);
            label3.TabIndex = 4;
            label3.Text = "İletişim bilgilerini buradan güncelleyebilirsiniz";
            // 
            // txt_telNo
            // 
            txt_telNo.BackColor = SystemColors.ControlLight;
            txt_telNo.Location = new Point(260, 667);
            txt_telNo.Name = "txt_telNo";
            txt_telNo.Size = new Size(190, 23);
            txt_telNo.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ControlLight;
            label4.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            label4.Location = new Point(114, 667);
            label4.Name = "label4";
            label4.Size = new Size(123, 30);
            label4.TabIndex = 6;
            label4.Text = "Telefon No";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ControlLight;
            label5.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            label5.Location = new Point(114, 721);
            label5.Name = "label5";
            label5.Size = new Size(86, 30);
            label5.TabIndex = 7;
            label5.Text = "E-Posta";
            // 
            // txt_eposta
            // 
            txt_eposta.BackColor = SystemColors.ControlLight;
            txt_eposta.Location = new Point(260, 730);
            txt_eposta.Name = "txt_eposta";
            txt_eposta.Size = new Size(190, 23);
            txt_eposta.TabIndex = 8;
            // 
            // btn_guncelle
            // 
            btn_guncelle.BackColor = SystemColors.ControlLight;
            btn_guncelle.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            btn_guncelle.Location = new Point(492, 685);
            btn_guncelle.Name = "btn_guncelle";
            btn_guncelle.Size = new Size(117, 44);
            btn_guncelle.TabIndex = 9;
            btn_guncelle.Text = "Güncelle";
            btn_guncelle.UseVisualStyleBackColor = false;
            btn_guncelle.Click += btn_guncelle_Click;
            // 
            // rtb_feedback
            // 
            rtb_feedback.BackColor = SystemColors.ControlLight;
            rtb_feedback.Font = new Font("Unispace", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            rtb_feedback.Location = new Point(864, 588);
            rtb_feedback.Name = "rtb_feedback";
            rtb_feedback.Size = new Size(561, 201);
            rtb_feedback.TabIndex = 10;
            rtb_feedback.Text = "";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ControlLight;
            label6.Font = new Font("Segoe UI Semibold", 19F, FontStyle.Bold | FontStyle.Italic);
            label6.Location = new Point(864, 525);
            label6.Name = "label6";
            label6.Size = new Size(561, 36);
            label6.TabIndex = 11;
            label6.Text = "\"Geri Bildirim - Görüşleriniz bizim için önemli!\"";
            // 
            // data_gecmisSiparis
            // 
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            data_gecmisSiparis.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            data_gecmisSiparis.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            data_gecmisSiparis.DefaultCellStyle = dataGridViewCellStyle6;
            data_gecmisSiparis.Location = new Point(1001, 109);
            data_gecmisSiparis.Name = "data_gecmisSiparis";
            data_gecmisSiparis.Size = new Size(399, 268);
            data_gecmisSiparis.TabIndex = 13;
            data_gecmisSiparis.CellClick += data_gecmisSiparis_CellClick;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Semibold", 19F, FontStyle.Bold);
            label7.ForeColor = SystemColors.ActiveCaption;
            label7.Location = new Point(1104, 49);
            label7.Name = "label7";
            label7.Size = new Size(217, 36);
            label7.TabIndex = 12;
            label7.Text = "Geçmiş Siparişler";
            // 
            // btn_musteriVeri
            // 
            btn_musteriVeri.BackColor = SystemColors.ControlLight;
            btn_musteriVeri.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            btn_musteriVeri.Location = new Point(47, 402);
            btn_musteriVeri.Name = "btn_musteriVeri";
            btn_musteriVeri.Size = new Size(230, 45);
            btn_musteriVeri.TabIndex = 14;
            btn_musteriVeri.Text = "Veri Çek";
            btn_musteriVeri.UseVisualStyleBackColor = false;
            btn_musteriVeri.Click += btnMusteriBilgi_Click;
            // 
            // btn_geri
            // 
            btn_geri.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_geri.Location = new Point(30, 22);
            btn_geri.Name = "btn_geri";
            btn_geri.Size = new Size(82, 38);
            btn_geri.TabIndex = 17;
            btn_geri.Text = "Geri";
            btn_geri.UseVisualStyleBackColor = true;
            btn_geri.Click += btn_geri_Click;
            // 
            // btn_gonder
            // 
            btn_gonder.Font = new Font("Segoe UI", 17.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btn_gonder.Location = new Point(1250, 795);
            btn_gonder.Name = "btn_gonder";
            btn_gonder.Size = new Size(150, 44);
            btn_gonder.TabIndex = 18;
            btn_gonder.Text = "Gönder";
            btn_gonder.UseVisualStyleBackColor = true;
            btn_gonder.Click += btn_gonder_Click;
            // 
            // btn_siparisVeri
            // 
            btn_siparisVeri.BackColor = SystemColors.ControlLight;
            btn_siparisVeri.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            btn_siparisVeri.Location = new Point(533, 402);
            btn_siparisVeri.Name = "btn_siparisVeri";
            btn_siparisVeri.Size = new Size(247, 45);
            btn_siparisVeri.TabIndex = 15;
            btn_siparisVeri.Text = "Veri Çek";
            btn_siparisVeri.UseVisualStyleBackColor = false;
            btn_siparisVeri.Click += btnSiparisBilgi_Click;
            // 
            // btn_gecmisSiparis
            // 
            btn_gecmisSiparis.BackColor = SystemColors.ControlLight;
            btn_gecmisSiparis.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            btn_gecmisSiparis.Location = new Point(1001, 402);
            btn_gecmisSiparis.Name = "btn_gecmisSiparis";
            btn_gecmisSiparis.Size = new Size(236, 45);
            btn_gecmisSiparis.TabIndex = 15;
            btn_gecmisSiparis.Text = "Veri Çek";
            btn_gecmisSiparis.UseVisualStyleBackColor = false;
            btn_gecmisSiparis.Click += btnGecmisSiparis_Click;
            // 
            // MusteriEkrani
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1456, 861);
            Controls.Add(btn_gonder);
            Controls.Add(btn_geri);
            Controls.Add(btn_gecmisSiparis);
            Controls.Add(btn_siparisVeri);
            Controls.Add(btn_musteriVeri);
            Controls.Add(data_gecmisSiparis);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(rtb_feedback);
            Controls.Add(btn_guncelle);
            Controls.Add(txt_eposta);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txt_telNo);
            Controls.Add(label3);
            Controls.Add(data_siparisBilgi);
            Controls.Add(label2);
            Controls.Add(data_musteriBilgi);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F);
            Name = "MusteriEkrani";
            Text = "MusteriEkrani";
            ((System.ComponentModel.ISupportInitialize)data_musteriBilgi).EndInit();
            ((System.ComponentModel.ISupportInitialize)data_siparisBilgi).EndInit();
            ((System.ComponentModel.ISupportInitialize)data_gecmisSiparis).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView data_musteriBilgi;
        private DataGridView data_siparisBilgi;
        private Label label2;
        private Label label3;
        private TextBox txt_telNo;
        private Label label4;
        private Label label5;
        private TextBox txt_eposta;
        private Button btn_guncelle;
        private RichTextBox rtb_feedback;
        private Label label6;
        private DataGridView data_gecmisSiparis;
        private Label label7;
        private Button btn_musteriVeri;
        private Button btn_gecmisSiprisVeri;
        
        private Button btn_geri;
        private Button btn_gonder;
        private Button btn_siparisVeri;
        private Button btn_gecmisSiparis;
    }
}