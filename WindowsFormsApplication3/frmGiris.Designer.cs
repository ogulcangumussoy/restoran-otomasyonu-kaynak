namespace WindowsFormsApplication3
{
    partial class frmGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGiris));
            this.cbKullanici = new System.Windows.Forms.ComboBox();
            this.tbMetin = new System.Windows.Forms.TextBox();
            this.lbAd = new System.Windows.Forms.Label();
            this.lbSifre = new System.Windows.Forms.Label();
            this.btnImage = new System.Windows.Forms.Button();
            this.btnCikisyap = new System.Windows.Forms.Button();
            this.btnGiris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbKullanici
            // 
            this.cbKullanici.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cbKullanici.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbKullanici.FormattingEnabled = true;
            this.cbKullanici.Location = new System.Drawing.Point(605, 375);
            this.cbKullanici.Name = "cbKullanici";
            this.cbKullanici.Size = new System.Drawing.Size(230, 32);
            this.cbKullanici.TabIndex = 0;
            this.cbKullanici.SelectedIndexChanged += new System.EventHandler(this.cbKullanici_SelectedIndexChanged);
            // 
            // tbMetin
            // 
            this.tbMetin.BackColor = System.Drawing.Color.LightGray;
            this.tbMetin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbMetin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbMetin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbMetin.Location = new System.Drawing.Point(605, 432);
            this.tbMetin.Multiline = true;
            this.tbMetin.Name = "tbMetin";
            this.tbMetin.Size = new System.Drawing.Size(230, 32);
            this.tbMetin.TabIndex = 1;
            this.tbMetin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbMetin.TextChanged += new System.EventHandler(this.tbMetin_TextChanged);
            // 
            // lbAd
            // 
            this.lbAd.AutoSize = true;
            this.lbAd.BackColor = System.Drawing.Color.Transparent;
            this.lbAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbAd.Location = new System.Drawing.Point(461, 375);
            this.lbAd.Name = "lbAd";
            this.lbAd.Size = new System.Drawing.Size(106, 20);
            this.lbAd.TabIndex = 3;
            this.lbAd.Text = "Kullanıcı Adı";
            // 
            // lbSifre
            // 
            this.lbSifre.AutoSize = true;
            this.lbSifre.BackColor = System.Drawing.Color.Transparent;
            this.lbSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbSifre.Location = new System.Drawing.Point(461, 432);
            this.lbSifre.Name = "lbSifre";
            this.lbSifre.Size = new System.Drawing.Size(47, 20);
            this.lbSifre.TabIndex = 3;
            this.lbSifre.Text = "Sifre";
            // 
            // btnImage
            // 
            this.btnImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnImage.BackgroundImage")));
            this.btnImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnImage.Location = new System.Drawing.Point(549, 201);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(286, 153);
            this.btnImage.TabIndex = 2;
            this.btnImage.UseVisualStyleBackColor = true;
            // 
            // btnCikisyap
            // 
            this.btnCikisyap.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCikisyap.BackgroundImage")));
            this.btnCikisyap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCikisyap.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCikisyap.Location = new System.Drawing.Point(777, 484);
            this.btnCikisyap.Name = "btnCikisyap";
            this.btnCikisyap.Size = new System.Drawing.Size(58, 60);
            this.btnCikisyap.TabIndex = 4;
            this.btnCikisyap.UseVisualStyleBackColor = true;
            this.btnCikisyap.Click += new System.EventHandler(this.btnCikisyap_Click);
            // 
            // btnGiris
            // 
            this.btnGiris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGiris.BackgroundImage")));
            this.btnGiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGiris.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGiris.Location = new System.Drawing.Point(616, 484);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(155, 60);
            this.btnGiris.TabIndex = 5;
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // frmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1121, 586);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.btnCikisyap);
            this.Controls.Add(this.lbSifre);
            this.Controls.Add(this.lbAd);
            this.Controls.Add(this.btnImage);
            this.Controls.Add(this.tbMetin);
            this.Controls.Add(this.cbKullanici);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmGiris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbKullanici;
        private System.Windows.Forms.TextBox tbMetin;
        private System.Windows.Forms.Label lbAd;
        private System.Windows.Forms.Label lbSifre;
        private System.Windows.Forms.Button btnImage;
        private System.Windows.Forms.Button btnCikisyap;
        private System.Windows.Forms.Button btnGiris;
    }
}

