
namespace AsyenUI.Forms
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.şirketBilgileriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CompanyInfoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mailBilgileriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SqlConnectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayarlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviceSaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviceStartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviceStopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviceDeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sQLSorgularıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sqlQueryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.şirketBilgileriToolStripMenuItem,
            this.ayarlarToolStripMenuItem,
            this.sQLSorgularıToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(553, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // şirketBilgileriToolStripMenuItem
            // 
            this.şirketBilgileriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CompanyInfoToolStripMenuItem1,
            this.mailBilgileriToolStripMenuItem,
            this.SqlConnectionToolStripMenuItem});
            this.şirketBilgileriToolStripMenuItem.Name = "şirketBilgileriToolStripMenuItem";
            this.şirketBilgileriToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.şirketBilgileriToolStripMenuItem.Text = "Genel Ayarlar";
            // 
            // CompanyInfoToolStripMenuItem1
            // 
            this.CompanyInfoToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("CompanyInfoToolStripMenuItem1.Image")));
            this.CompanyInfoToolStripMenuItem1.Name = "CompanyInfoToolStripMenuItem1";
            this.CompanyInfoToolStripMenuItem1.Size = new System.Drawing.Size(184, 22);
            this.CompanyInfoToolStripMenuItem1.Text = "Şirket Bilgileri";
            this.CompanyInfoToolStripMenuItem1.Click += new System.EventHandler(this.CompanyInfoToolStripMenuItem1_Click);
            // 
            // mailBilgileriToolStripMenuItem
            // 
            this.mailBilgileriToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("mailBilgileriToolStripMenuItem.Image")));
            this.mailBilgileriToolStripMenuItem.Name = "mailBilgileriToolStripMenuItem";
            this.mailBilgileriToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.mailBilgileriToolStripMenuItem.Text = "Mail Bilgileri";
            this.mailBilgileriToolStripMenuItem.Click += new System.EventHandler(this.mailBilgileriToolStripMenuItem_Click);
            // 
            // SqlConnectionToolStripMenuItem
            // 
            this.SqlConnectionToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("SqlConnectionToolStripMenuItem.Image")));
            this.SqlConnectionToolStripMenuItem.Name = "SqlConnectionToolStripMenuItem";
            this.SqlConnectionToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.SqlConnectionToolStripMenuItem.Text = "SQL Bağlantı Ayarları";
            this.SqlConnectionToolStripMenuItem.Click += new System.EventHandler(this.SqlConnectionToolStripMenuItem_Click);
            // 
            // ayarlarToolStripMenuItem
            // 
            this.ayarlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serviceSaveToolStripMenuItem,
            this.serviceStartToolStripMenuItem,
            this.serviceStopToolStripMenuItem,
            this.serviceDeleteToolStripMenuItem});
            this.ayarlarToolStripMenuItem.Name = "ayarlarToolStripMenuItem";
            this.ayarlarToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.ayarlarToolStripMenuItem.Text = "Servis Ayarları";
            // 
            // serviceSaveToolStripMenuItem
            // 
            this.serviceSaveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("serviceSaveToolStripMenuItem.Image")));
            this.serviceSaveToolStripMenuItem.Name = "serviceSaveToolStripMenuItem";
            this.serviceSaveToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.serviceSaveToolStripMenuItem.Text = "Servisi Kaydet";
            this.serviceSaveToolStripMenuItem.Click += new System.EventHandler(this.serviceSaveToolStripMenuItem_Click);
            // 
            // serviceStartToolStripMenuItem
            // 
            this.serviceStartToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("serviceStartToolStripMenuItem.Image")));
            this.serviceStartToolStripMenuItem.Name = "serviceStartToolStripMenuItem";
            this.serviceStartToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.serviceStartToolStripMenuItem.Text = "Servisi Başlat";
            this.serviceStartToolStripMenuItem.Click += new System.EventHandler(this.serviceStartToolStripMenuItem_Click);
            // 
            // serviceStopToolStripMenuItem
            // 
            this.serviceStopToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("serviceStopToolStripMenuItem.Image")));
            this.serviceStopToolStripMenuItem.Name = "serviceStopToolStripMenuItem";
            this.serviceStopToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.serviceStopToolStripMenuItem.Text = "Servisi Durdur";
            this.serviceStopToolStripMenuItem.Click += new System.EventHandler(this.serviceStopToolStripMenuItem_Click);
            // 
            // serviceDeleteToolStripMenuItem
            // 
            this.serviceDeleteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("serviceDeleteToolStripMenuItem.Image")));
            this.serviceDeleteToolStripMenuItem.Name = "serviceDeleteToolStripMenuItem";
            this.serviceDeleteToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.serviceDeleteToolStripMenuItem.Text = "Servisi Sil";
            this.serviceDeleteToolStripMenuItem.Click += new System.EventHandler(this.serviceDeleteToolStripMenuItem_Click);
            // 
            // sQLSorgularıToolStripMenuItem
            // 
            this.sQLSorgularıToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sqlQueryToolStripMenuItem});
            this.sQLSorgularıToolStripMenuItem.Name = "sQLSorgularıToolStripMenuItem";
            this.sQLSorgularıToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.sQLSorgularıToolStripMenuItem.Text = "SQL Sorguları";
            // 
            // sqlQueryToolStripMenuItem
            // 
            this.sqlQueryToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sqlQueryToolStripMenuItem.Image")));
            this.sqlQueryToolStripMenuItem.Name = "sqlQueryToolStripMenuItem";
            this.sqlQueryToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.sqlQueryToolStripMenuItem.Text = "Sorgu Düzenleme Ekranı";
            this.sqlQueryToolStripMenuItem.Click += new System.EventHandler(this.sqlQueryToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(55, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(450, 130);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(553, 318);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("Home.IconOptions.Image")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asyen Otomatik İşlemler";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Home_FormClosed);
            this.Load += new System.EventHandler(this.Home_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ayarlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviceSaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviceStartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviceStopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviceDeleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem şirketBilgileriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CompanyInfoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mailBilgileriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SqlConnectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sQLSorgularıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sqlQueryToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}