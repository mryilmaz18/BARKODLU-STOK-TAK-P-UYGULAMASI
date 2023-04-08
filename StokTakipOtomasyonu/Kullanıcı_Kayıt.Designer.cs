
namespace StokTakipOtomasyonu
{
    partial class Kullanici_Kayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kullanici_Kayit));
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.txtParola = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtKullanıcıAd = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtTC = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtAdSoyad = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.GirisYap = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.txtParola);
            this.bunifuGradientPanel1.Controls.Add(this.txtKullanıcıAd);
            this.bunifuGradientPanel1.Controls.Add(this.txtTC);
            this.bunifuGradientPanel1.Controls.Add(this.txtAdSoyad);
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox6);
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox5);
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox3);
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox2);
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox1);
            this.bunifuGradientPanel1.Controls.Add(this.label2);
            this.bunifuGradientPanel1.Controls.Add(this.GirisYap);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(23)))), ((int)(((byte)(65)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(769, 506);
            this.bunifuGradientPanel1.TabIndex = 12;
            this.bunifuGradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.bunifuGradientPanel1_Paint);
            // 
            // txtParola
            // 
            this.txtParola.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtParola.Font = new System.Drawing.Font("Copperplate Gothic Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParola.ForeColor = System.Drawing.Color.White;
            this.txtParola.HintForeColor = System.Drawing.Color.Teal;
            this.txtParola.HintText = "";
            this.txtParola.isPassword = false;
            this.txtParola.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(33)))), ((int)(((byte)(62)))));
            this.txtParola.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(33)))), ((int)(((byte)(62)))));
            this.txtParola.LineMouseHoverColor = System.Drawing.Color.CornflowerBlue;
            this.txtParola.LineThickness = 4;
            this.txtParola.Location = new System.Drawing.Point(360, 362);
            this.txtParola.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtParola.Name = "txtParola";
            this.txtParola.Size = new System.Drawing.Size(289, 48);
            this.txtParola.TabIndex = 4;
            this.txtParola.Text = "Parola Giriniz";
            this.txtParola.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtParola.OnValueChanged += new System.EventHandler(this.txtParola_OnValueChanged);
            this.txtParola.Enter += new System.EventHandler(this.txtParola_Enter);
            this.txtParola.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtParola_KeyDown);
            this.txtParola.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtParola_KeyPress);
            this.txtParola.Leave += new System.EventHandler(this.txtParola_Leave);
            // 
            // txtKullanıcıAd
            // 
            this.txtKullanıcıAd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKullanıcıAd.Font = new System.Drawing.Font("Copperplate Gothic Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKullanıcıAd.ForeColor = System.Drawing.Color.White;
            this.txtKullanıcıAd.HintForeColor = System.Drawing.Color.Teal;
            this.txtKullanıcıAd.HintText = "";
            this.txtKullanıcıAd.isPassword = false;
            this.txtKullanıcıAd.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(33)))), ((int)(((byte)(62)))));
            this.txtKullanıcıAd.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(33)))), ((int)(((byte)(62)))));
            this.txtKullanıcıAd.LineMouseHoverColor = System.Drawing.Color.CornflowerBlue;
            this.txtKullanıcıAd.LineThickness = 4;
            this.txtKullanıcıAd.Location = new System.Drawing.Point(360, 286);
            this.txtKullanıcıAd.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtKullanıcıAd.Name = "txtKullanıcıAd";
            this.txtKullanıcıAd.Size = new System.Drawing.Size(289, 48);
            this.txtKullanıcıAd.TabIndex = 3;
            this.txtKullanıcıAd.Text = "Kullanıcı Adı Giriniz";
            this.txtKullanıcıAd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtKullanıcıAd.Enter += new System.EventHandler(this.txtKullanıcıAd_Enter);
            this.txtKullanıcıAd.Leave += new System.EventHandler(this.txtKullanıcıAd_Leave);
            // 
            // txtTC
            // 
            this.txtTC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTC.Font = new System.Drawing.Font("Copperplate Gothic Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTC.ForeColor = System.Drawing.Color.White;
            this.txtTC.HintForeColor = System.Drawing.Color.Teal;
            this.txtTC.HintText = "";
            this.txtTC.isPassword = false;
            this.txtTC.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(33)))), ((int)(((byte)(62)))));
            this.txtTC.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(33)))), ((int)(((byte)(62)))));
            this.txtTC.LineMouseHoverColor = System.Drawing.Color.CornflowerBlue;
            this.txtTC.LineThickness = 4;
            this.txtTC.Location = new System.Drawing.Point(360, 212);
            this.txtTC.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(289, 48);
            this.txtTC.TabIndex = 2;
            this.txtTC.Text = "Tc Giriniz";
            this.txtTC.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTC.Enter += new System.EventHandler(this.txtTC_Enter);
            this.txtTC.Leave += new System.EventHandler(this.txtTC_Leave);
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAdSoyad.Font = new System.Drawing.Font("Copperplate Gothic Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdSoyad.ForeColor = System.Drawing.SystemColors.Window;
            this.txtAdSoyad.HintForeColor = System.Drawing.Color.Teal;
            this.txtAdSoyad.HintText = "";
            this.txtAdSoyad.isPassword = false;
            this.txtAdSoyad.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(33)))), ((int)(((byte)(62)))));
            this.txtAdSoyad.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(33)))), ((int)(((byte)(62)))));
            this.txtAdSoyad.LineMouseHoverColor = System.Drawing.Color.CornflowerBlue;
            this.txtAdSoyad.LineThickness = 4;
            this.txtAdSoyad.Location = new System.Drawing.Point(360, 140);
            this.txtAdSoyad.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(289, 48);
            this.txtAdSoyad.TabIndex = 1;
            this.txtAdSoyad.Text = "Ad Soyad Giriniz";
            this.txtAdSoyad.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAdSoyad.OnValueChanged += new System.EventHandler(this.txtAdSoyad_OnValueChanged);
            this.txtAdSoyad.Enter += new System.EventHandler(this.txtAdSoyad_Enter);
            this.txtAdSoyad.Leave += new System.EventHandler(this.txtAdSoyad_Leave);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(307, 288);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(44, 46);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 17;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(307, 214);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(44, 46);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 14;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(307, 362);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(44, 48);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(307, 140);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(44, 46);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(57, 197);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 152);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Copperplate Gothic Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(212)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(134, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(515, 40);
            this.label2.TabIndex = 5;
            this.label2.Text = "KULLANICI KAYIT PANELİ";
            // 
            // GirisYap
            // 
            this.GirisYap.ActiveBorderThickness = 1;
            this.GirisYap.ActiveCornerRadius = 20;
            this.GirisYap.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(33)))), ((int)(((byte)(62)))));
            this.GirisYap.ActiveForecolor = System.Drawing.Color.Transparent;
            this.GirisYap.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(33)))), ((int)(((byte)(62)))));
            this.GirisYap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.GirisYap.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GirisYap.BackgroundImage")));
            this.GirisYap.ButtonText = "Kayıt Ol";
            this.GirisYap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GirisYap.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GirisYap.ForeColor = System.Drawing.Color.Black;
            this.GirisYap.IdleBorderThickness = 1;
            this.GirisYap.IdleCornerRadius = 20;
            this.GirisYap.IdleFillColor = System.Drawing.Color.Transparent;
            this.GirisYap.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(33)))), ((int)(((byte)(62)))));
            this.GirisYap.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(33)))), ((int)(((byte)(62)))));
            this.GirisYap.Location = new System.Drawing.Point(510, 451);
            this.GirisYap.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.GirisYap.Name = "GirisYap";
            this.GirisYap.Size = new System.Drawing.Size(244, 40);
            this.GirisYap.TabIndex = 5;
            this.GirisYap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.GirisYap.Click += new System.EventHandler(this.GirisYap_Click);
            this.GirisYap.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GirisYap_KeyDown);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(784, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(41, 40);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // Kullanici_Kayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(837, 506);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "Kullanici_Kayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı_Kayıt";
            this.Load += new System.EventHandler(this.Kullanıcı_Kayıt_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private Bunifu.Framework.UI.BunifuThinButton2 GirisYap;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtAdSoyad;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtParola;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtKullanıcıAd;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtTC;
    }
}