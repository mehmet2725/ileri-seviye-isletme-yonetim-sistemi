namespace ileri_seviye_depo_stoğu_projesi
{
    partial class GirisEkrani
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisEkrani));
            btn_musteri = new Button();
            btn_calisan = new Button();
            btn_yonetici = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // btn_musteri
            // 
            btn_musteri.BackgroundImage = (Image)resources.GetObject("btn_musteri.BackgroundImage");
            btn_musteri.BackgroundImageLayout = ImageLayout.Zoom;
            btn_musteri.FlatStyle = FlatStyle.Popup;
            btn_musteri.ImageAlign = ContentAlignment.TopCenter;
            btn_musteri.Location = new Point(121, 220);
            btn_musteri.Name = "btn_musteri";
            btn_musteri.Size = new Size(196, 159);
            btn_musteri.TabIndex = 0;
            btn_musteri.UseVisualStyleBackColor = true;
            btn_musteri.Click += btn_musteri_Click;
            // 
            // btn_calisan
            // 
            btn_calisan.BackgroundImage = (Image)resources.GetObject("btn_calisan.BackgroundImage");
            btn_calisan.BackgroundImageLayout = ImageLayout.Zoom;
            btn_calisan.FlatStyle = FlatStyle.Popup;
            btn_calisan.Location = new Point(444, 212);
            btn_calisan.Name = "btn_calisan";
            btn_calisan.Size = new Size(196, 167);
            btn_calisan.TabIndex = 1;
            btn_calisan.UseVisualStyleBackColor = true;
            btn_calisan.Click += btn_calisan_Click;
            // 
            // btn_yonetici
            // 
            btn_yonetici.BackgroundImage = (Image)resources.GetObject("btn_yonetici.BackgroundImage");
            btn_yonetici.BackgroundImageLayout = ImageLayout.Zoom;
            btn_yonetici.FlatStyle = FlatStyle.Popup;
            btn_yonetici.Location = new Point(757, 212);
            btn_yonetici.Name = "btn_yonetici";
            btn_yonetici.Size = new Size(196, 167);
            btn_yonetici.TabIndex = 2;
            btn_yonetici.UseVisualStyleBackColor = true;
            btn_yonetici.Click += btn_yonetici_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label1.ForeColor = SystemColors.ControlDark;
            label1.Location = new Point(121, 137);
            label1.Name = "label1";
            label1.Size = new Size(104, 32);
            label1.TabIndex = 3;
            label1.Text = "Müşteri";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label2.ForeColor = SystemColors.ButtonShadow;
            label2.Location = new Point(444, 137);
            label2.Name = "label2";
            label2.Size = new Size(99, 32);
            label2.TabIndex = 4;
            label2.Text = "Çalışan";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label3.ForeColor = SystemColors.ButtonShadow;
            label3.Location = new Point(757, 137);
            label3.Name = "label3";
            label3.Size = new Size(107, 32);
            label3.TabIndex = 5;
            label3.Text = "Yönetici";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.ForeColor = SystemColors.GradientActiveCaption;
            label4.Location = new Point(121, 43);
            label4.Name = "label4";
            label4.Size = new Size(604, 31);
            label4.TabIndex = 6;
            label4.Text = "İleri Seviye İşletme Yönetim Sistemine Hoşgeldiniz";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Stencil", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(973, 625);
            label5.Name = "label5";
            label5.Size = new Size(280, 19);
            label5.TabIndex = 7;
            label5.Text = "Developed by Mehmet Sönmez";
            // 
            // GirisEkrani
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1305, 731);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_yonetici);
            Controls.Add(btn_calisan);
            Controls.Add(btn_musteri);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "GirisEkrani";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        // private Button btn_sil;
        private Button btn_musteri;
        private Button btn_calisan;
        private Button btn_yonetici;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
