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
            label4 = new Label();
            label5 = new Label();
            label1 = new Label();
            btn_giris = new Button();
            txt_kulAd = new TextBox();
            txt_sifre = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label6 = new Label();
            chk_sifreGoster = new CheckBox();
            SuspendLayout();
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
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = SystemColors.Info;
            label1.Location = new Point(414, 154);
            label1.Name = "label1";
            label1.Size = new Size(397, 30);
            label1.TabIndex = 8;
            label1.Text = "Lütfen Kullanıcı Adınızı Ve Şifrenizi Girniz";
            // 
            // btn_giris
            // 
            btn_giris.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_giris.BackColor = SystemColors.ActiveCaption;
            btn_giris.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btn_giris.ForeColor = SystemColors.ActiveCaptionText;
            btn_giris.Location = new Point(744, 366);
            btn_giris.Name = "btn_giris";
            btn_giris.Size = new Size(105, 44);
            btn_giris.TabIndex = 9;
            btn_giris.Text = "Giriş";
            btn_giris.UseVisualStyleBackColor = false;
            btn_giris.Click += btn_giris_Click;
            // 
            // txt_kulAd
            // 
            txt_kulAd.BackColor = SystemColors.InactiveCaption;
            txt_kulAd.Location = new Point(608, 242);
            txt_kulAd.Name = "txt_kulAd";
            txt_kulAd.Size = new Size(203, 23);
            txt_kulAd.TabIndex = 10;
            // 
            // txt_sifre
            // 
            txt_sifre.BackColor = SystemColors.InactiveCaption;
            txt_sifre.Location = new Point(608, 316);
            txt_sifre.Name = "txt_sifre";
            txt_sifre.Size = new Size(203, 23);
            txt_sifre.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = SystemColors.ActiveCaption;
            label2.Location = new Point(414, 240);
            label2.Name = "label2";
            label2.Size = new Size(119, 25);
            label2.TabIndex = 12;
            label2.Text = "Kullanıcı Adı";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ActiveCaption;
            label3.Location = new Point(414, 319);
            label3.Name = "label3";
            label3.Size = new Size(51, 25);
            label3.TabIndex = 13;
            label3.Text = "Şifre";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(333, 366);
            label6.Name = "label6";
            label6.Size = new Size(378, 15);
            label6.TabIndex = 14;
            label6.Text = "*Üye değilseniz lütfen yöneticiden kullanıcı adı ve şifrenizi talep ediniz*";
            // 
            // chk_sifreGoster
            // 
            chk_sifreGoster.AutoSize = true;
            chk_sifreGoster.Location = new Point(829, 317);
            chk_sifreGoster.Name = "chk_sifreGoster";
            chk_sifreGoster.Size = new Size(90, 19);
            chk_sifreGoster.TabIndex = 15;
            chk_sifreGoster.Text = "Göster/Gizle";
            chk_sifreGoster.UseVisualStyleBackColor = true;
            chk_sifreGoster.CheckedChanged += chk_sifreGoster_CheckedChanged;
            // 
            // GirisEkrani
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1305, 731);
            Controls.Add(chk_sifreGoster);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txt_sifre);
            Controls.Add(txt_kulAd);
            Controls.Add(btn_giris);
            Controls.Add(label1);
            Controls.Add(label5);
            Controls.Add(label4);
            DoubleBuffered = true;
            Name = "GirisEkrani";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GirisEkrani";
 
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label4;
        private Label label5;
        private Label label1;
        private Button btn_giris;
        private TextBox txt_kulAd;
        private TextBox txt_sifre;
        private Label label2;
        private Label label3;
        private Label label6;
        private CheckBox chk_sifreGoster;
    }
}
