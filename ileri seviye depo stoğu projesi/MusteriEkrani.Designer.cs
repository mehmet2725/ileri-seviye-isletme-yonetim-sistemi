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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusteriEkrani));
            label1 = new Label();
            txt_sifre = new TextBox();
            txt_kulAd = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btn_geri = new Button();
            btn_giris = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightGray;
            label1.Font = new Font("Stencil", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.InfoText;
            label1.Location = new Point(211, 68);
            label1.Name = "label1";
            label1.Size = new Size(539, 34);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Adı Ve Şifrenizi Giriniz";
            // 
            // txt_sifre
            // 
            txt_sifre.BackColor = SystemColors.ActiveCaption;
            txt_sifre.Location = new Point(390, 217);
            txt_sifre.Name = "txt_sifre";
            txt_sifre.Size = new Size(100, 23);
            txt_sifre.TabIndex = 1;
            // 
            // txt_kulAd
            // 
            txt_kulAd.BackColor = SystemColors.ActiveCaption;
            txt_kulAd.Location = new Point(390, 168);
            txt_kulAd.Name = "txt_kulAd";
            txt_kulAd.Size = new Size(100, 23);
            txt_kulAd.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Cyan;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(281, 176);
            label2.Name = "label2";
            label2.Size = new Size(81, 17);
            label2.TabIndex = 3;
            label2.Text = "Kullanıcı Adı";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Aqua;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(281, 225);
            label3.Name = "label3";
            label3.Size = new Size(34, 17);
            label3.TabIndex = 4;
            label3.Text = "Şifre";
            // 
            // btn_geri
            // 
            btn_geri.BackColor = Color.DimGray;
            btn_geri.BackgroundImage = (Image)resources.GetObject("btn_geri.BackgroundImage");
            btn_geri.BackgroundImageLayout = ImageLayout.Stretch;
            btn_geri.Location = new Point(12, 12);
            btn_geri.Name = "btn_geri";
            btn_geri.Size = new Size(65, 65);
            btn_geri.TabIndex = 5;
            btn_geri.UseVisualStyleBackColor = false;
            btn_geri.Click += btn_geri_Click;
            // 
            // btn_giris
            // 
            btn_giris.BackColor = Color.Cyan;
            btn_giris.Location = new Point(409, 261);
            btn_giris.Name = "btn_giris";
            btn_giris.Size = new Size(81, 28);
            btn_giris.TabIndex = 13;
            btn_giris.Text = "Giriş Yap";
            btn_giris.UseVisualStyleBackColor = false;
            // 
            // MusteriEkrani
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(878, 415);
            Controls.Add(btn_giris);
            Controls.Add(btn_geri);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txt_kulAd);
            Controls.Add(txt_sifre);
            Controls.Add(label1);
            Name = "MusteriEkrani";
            Text = "MusteriEkrani";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_sifre;
        private TextBox txt_kulAd;
        private Label label2;
        private Label label3;
        private Button btn_geri;
        private Button btn_giris;
    }
}