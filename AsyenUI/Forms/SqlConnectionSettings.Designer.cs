
namespace AsyenUI.Forms
{
    partial class SqlConnectionSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SqlConnectionSettings));
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Password = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_LoginName = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ServerName = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_DatabaseName = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Password.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_LoginName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ServerName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DatabaseName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.label3.Location = new System.Drawing.Point(12, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 21);
            this.label3.TabIndex = 14;
            this.label3.Text = "Şifre:";
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(144, 69);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Properties.MaxLength = 30;
            this.txt_Password.Properties.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(261, 20);
            this.txt_Password.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.label2.Location = new System.Drawing.Point(12, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "Kullanıcı Adı:";
            // 
            // txt_LoginName
            // 
            this.txt_LoginName.Location = new System.Drawing.Point(144, 36);
            this.txt_LoginName.Name = "txt_LoginName";
            this.txt_LoginName.Properties.MaxLength = 20;
            this.txt_LoginName.Size = new System.Drawing.Size(261, 20);
            this.txt_LoginName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.label1.Location = new System.Drawing.Point(12, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Server Adı:";
            // 
            // txt_ServerName
            // 
            this.txt_ServerName.Location = new System.Drawing.Point(144, 5);
            this.txt_ServerName.Name = "txt_ServerName";
            this.txt_ServerName.Properties.MaxLength = 50;
            this.txt_ServerName.Size = new System.Drawing.Size(261, 20);
            this.txt_ServerName.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.label4.Location = new System.Drawing.Point(12, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 21);
            this.label4.TabIndex = 16;
            this.label4.Text = "Veri Tabanı Adı:";
            // 
            // txt_DatabaseName
            // 
            this.txt_DatabaseName.Location = new System.Drawing.Point(144, 100);
            this.txt_DatabaseName.Name = "txt_DatabaseName";
            this.txt_DatabaseName.Properties.MaxLength = 20;
            this.txt_DatabaseName.Size = new System.Drawing.Size(261, 20);
            this.txt_DatabaseName.TabIndex = 3;
            // 
            // SqlConnectionSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(413, 145);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_DatabaseName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_LoginName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_ServerName);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("SqlConnectionSettings.IconOptions.Image")));
            this.MaximizeBox = false;
            this.Name = "SqlConnectionSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SQL Bağlantı Ayarları";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SqlConnectionSettings_FormClosing);
            this.Load += new System.EventHandler(this.SqlConnectionSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_Password.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_LoginName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ServerName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DatabaseName.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit txt_Password;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txt_LoginName;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txt_ServerName;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit txt_DatabaseName;
    }
}