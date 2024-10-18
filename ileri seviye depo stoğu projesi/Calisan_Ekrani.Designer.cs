namespace ileri_seviye_depo_stoğu_projesi
{
    partial class Calisan_Ekrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calisan_Ekrani));
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
            btn_geri.BackColor = Color.Gainsboro;
            btn_geri.BackgroundImage = (Image)resources.GetObject("btn_geri.BackgroundImage");
            btn_geri.BackgroundImageLayout = ImageLayout.Stretch;
            btn_geri.Location = new Point(24, 12);
            btn_geri.Name = "btn_geri";
            btn_geri.Size = new Size(65, 65);
            btn_geri.TabIndex = 11;
            btn_geri.UseVisualStyleBackColor = false;
            btn_geri.Click += btn_geri_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.MintCream;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(262, 253);
            label3.Name = "label3";
            label3.Size = new Size(34, 17);
            label3.TabIndex = 10;
            label3.Text = "Şifre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.MintCream;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(262, 204);
            label2.Name = "label2";
            label2.Size = new Size(81, 17);
            label2.TabIndex = 9;
            label2.Text = "Kullanıcı Adı";
            // 
            // txt_kulAd
            // 
            txt_kulAd.BackColor = SystemColors.ActiveCaption;
            txt_kulAd.Location = new Point(371, 196);
            txt_kulAd.Name = "txt_kulAd";
            txt_kulAd.Size = new Size(100, 23);
            txt_kulAd.TabIndex = 8;
            // 
            // txt_sifre
            // 
            txt_sifre.BackColor = SystemColors.ActiveCaption;
            txt_sifre.Location = new Point(371, 245);
            txt_sifre.Name = "txt_sifre";
            txt_sifre.Size = new Size(100, 23);
            txt_sifre.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightSteelBlue;
            label1.Font = new Font("Stencil", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.InfoText;
            label1.Location = new Point(192, 96);
            label1.Name = "label1";
            label1.Size = new Size(539, 34);
            label1.TabIndex = 6;
            label1.Text = "Kullanıcı Adı Ve Şifrenizi Giriniz";
            // 
            // button1
            // 
            button1.BackColor = Color.MintCream;
            button1.Location = new Point(390, 289);
            button1.Name = "button1";
            button1.Size = new Size(81, 28);
            button1.TabIndex = 13;
            button1.Text = "Giriş Yap";
            button1.UseVisualStyleBackColor = false;
            // 
            // Calisan_Ekrani
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(881, 408);
            Controls.Add(button1);
            Controls.Add(btn_geri);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txt_kulAd);
            Controls.Add(txt_sifre);
            Controls.Add(label1);
            Name = "Calisan_Ekrani";
            Text = "Calisan_Ekrani";
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