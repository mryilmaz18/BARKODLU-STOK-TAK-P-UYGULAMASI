
namespace StokTakipOtomasyonu
{
    partial class SatısListele
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SatısListele));
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ButtonSatisSil = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.ButtonSatisSil);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomLabel6);
            this.bunifuGradientPanel1.Controls.Add(this.dataGridView1);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.DarkRed;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.Khaki;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.Navy;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Firebrick;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(1095, 617);
            this.bunifuGradientPanel1.TabIndex = 3;
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Copperplate Gothic Bold", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(311, 9);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(417, 30);
            this.bunifuCustomLabel6.TabIndex = 28;
            this.bunifuCustomLabel6.Text = "SATIS LISTELEME SAYFASI";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightSalmon;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1071, 520);
            this.dataGridView1.TabIndex = 0;
            // 
            // ButtonSatisSil
            // 
            this.ButtonSatisSil.ActiveBorderThickness = 1;
            this.ButtonSatisSil.ActiveCornerRadius = 20;
            this.ButtonSatisSil.ActiveFillColor = System.Drawing.Color.Khaki;
            this.ButtonSatisSil.ActiveForecolor = System.Drawing.Color.Black;
            this.ButtonSatisSil.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.ButtonSatisSil.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ButtonSatisSil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonSatisSil.BackgroundImage")));
            this.ButtonSatisSil.ButtonText = "Satıs Sil";
            this.ButtonSatisSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonSatisSil.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSatisSil.ForeColor = System.Drawing.Color.SeaGreen;
            this.ButtonSatisSil.IdleBorderThickness = 1;
            this.ButtonSatisSil.IdleCornerRadius = 20;
            this.ButtonSatisSil.IdleFillColor = System.Drawing.Color.White;
            this.ButtonSatisSil.IdleForecolor = System.Drawing.Color.Black;
            this.ButtonSatisSil.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.ButtonSatisSil.Location = new System.Drawing.Point(955, 578);
            this.ButtonSatisSil.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonSatisSil.Name = "ButtonSatisSil";
            this.ButtonSatisSil.Size = new System.Drawing.Size(127, 32);
            this.ButtonSatisSil.TabIndex = 29;
            this.ButtonSatisSil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ButtonSatisSil.Click += new System.EventHandler(this.ButtonSatisSil_Click);
            // 
            // SatısListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 617);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SatısListele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SatısListele";
            this.Load += new System.EventHandler(this.SatısListele_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Bunifu.Framework.UI.BunifuThinButton2 ButtonSatisSil;
    }
}