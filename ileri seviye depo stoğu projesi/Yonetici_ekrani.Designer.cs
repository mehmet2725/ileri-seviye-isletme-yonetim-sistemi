namespace ileri_seviye_depo_stoğu_projesi
{
    partial class Yonetici_ekrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Yonetici_ekrani));
            btn_geri = new Button();
            label3 = new Label();
            label2 = new Label();
            txt_kulAd = new TextBox();
            txt_sifre = new TextBox();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // btn_geri
            // 
            btn_geri.BackColor = Color.DodgerBlue;
            btn_geri.BackgroundImage = (Image)resources.GetObject("btn_geri.BackgroundImage");
            btn_geri.BackgroundImageLayout = ImageLayout.Stretch;
            btn_geri.Location = new Point(8, 60);
            btn_geri.Name = "btn_geri";
            btn_geri.Size = new Size(65, 65);
            btn_geri.TabIndex = 11;
            btn_geri.UseVisualStyleBackColor = false;
            btn_geri.Click += btn_geri_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.CornflowerBlue;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(201, 262);
            label3.Name = "label3";
            label3.Size = new Size(34, 17);
            label3.TabIndex = 10;
            label3.Text = "Şifre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.CornflowerBlue;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(201, 213);
            label2.Name = "label2";
            label2.Size = new Size(81, 17);
            label2.TabIndex = 9;
            label2.Text = "Kullanıcı Adı";
            // 
            // txt_kulAd
            // 
            txt_kulAd.BackColor = SystemColors.ActiveCaption;
            txt_kulAd.Location = new Point(310, 205);
            txt_kulAd.Name = "txt_kulAd";
            txt_kulAd.Size = new Size(100, 23);
            txt_kulAd.TabIndex = 8;
            // 
            // txt_sifre
            // 
            txt_sifre.BackColor = SystemColors.ActiveCaption;
            txt_sifre.Location = new Point(310, 254);
            txt_sifre.Name = "txt_sifre";
            txt_sifre.Size = new Size(100, 23);
            txt_sifre.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightSkyBlue;
            label1.Font = new Font("Stencil", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.InfoText;
            label1.Location = new Point(131, 105);
            label1.Name = "label1";
            label1.Size = new Size(539, 34);
            label1.TabIndex = 6;
            label1.Text = "Kullanıcı Adı Ve Şifrenizi Giriniz";
            // 
            // button1
            // 
            button1.BackColor = Color.CornflowerBlue;
            button1.Location = new Point(329, 309);
            button1.Name = "button1";
            button1.Size = new Size(81, 28);
            button1.TabIndex = 12;
            button1.Text = "Giriş Yap";
            button1.UseVisualStyleBackColor = false;
            // 
            // Yonetici_ekrani
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(btn_geri);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txt_kulAd);
            Controls.Add(txt_sifre);
            Controls.Add(label1);
            Name = "Yonetici_ekrani";
            Text = "Yonetici_ekrani";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_geri;
        private Label label3;
        private Label label2;
        private TextBox txt_kulAd;
        private TextBox txt_sifre;
        private Label label1;
        private Button button1;
    }
}