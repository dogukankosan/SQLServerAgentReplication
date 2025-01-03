﻿
namespace AsyenUI.Forms
{
    partial class MailSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MailSettings));
            this.label5 = new System.Windows.Forms.Label();
            this.txt_recipientEmail = new DevExpress.XtraEditors.TextEdit();
            this.btn_SendMail = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Update = new DevExpress.XtraEditors.SimpleButton();
            this.chk_SSL = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Port = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Password = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Server = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Email = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_recipientEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Port.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Password.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Server.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Email.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 45;
            this.label5.Text = "Kime Gönderilecek:";
            // 
            // txt_recipientEmail
            // 
            this.txt_recipientEmail.Location = new System.Drawing.Point(119, 36);
            this.txt_recipientEmail.Name = "txt_recipientEmail";
            this.txt_recipientEmail.Properties.MaxLength = 50;
            this.txt_recipientEmail.Size = new System.Drawing.Size(189, 20);
            this.txt_recipientEmail.TabIndex = 1;
            // 
            // btn_SendMail
            // 
            this.btn_SendMail.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Warning;
            this.btn_SendMail.Appearance.Font = new System.Drawing.Font("Tahoma", 18.25F);
            this.btn_SendMail.Appearance.Options.UseBackColor = true;
            this.btn_SendMail.Appearance.Options.UseFont = true;
            this.btn_SendMail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SendMail.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_SendMail.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_SendMail.ImageOptions.Image")));
            this.btn_SendMail.Location = new System.Drawing.Point(0, 208);
            this.btn_SendMail.Name = "btn_SendMail";
            this.btn_SendMail.Size = new System.Drawing.Size(320, 58);
            this.btn_SendMail.TabIndex = 6;
            this.btn_SendMail.Text = "Test Maili Gönder";
            this.btn_SendMail.Click += new System.EventHandler(this.btn_SendMail_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.btn_Update.Appearance.Font = new System.Drawing.Font("Tahoma", 18.25F);
            this.btn_Update.Appearance.Options.UseBackColor = true;
            this.btn_Update.Appearance.Options.UseFont = true;
            this.btn_Update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Update.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_Update.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Update.ImageOptions.Image")));
            this.btn_Update.Location = new System.Drawing.Point(0, 266);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(320, 58);
            this.btn_Update.TabIndex = 7;
            this.btn_Update.Text = "Güncelle";
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // chk_SSL
            // 
            this.chk_SSL.AutoSize = true;
            this.chk_SSL.Location = new System.Drawing.Point(119, 168);
            this.chk_SSL.Name = "chk_SSL";
            this.chk_SSL.Size = new System.Drawing.Size(99, 17);
            this.chk_SSL.TabIndex = 5;
            this.chk_SSL.Text = "SSL Olucak Mı ?";
            this.chk_SSL.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "Port:";
            // 
            // txt_Port
            // 
            this.txt_Port.Location = new System.Drawing.Point(119, 130);
            this.txt_Port.Name = "txt_Port";
            this.txt_Port.Properties.MaxLength = 4;
            this.txt_Port.Size = new System.Drawing.Size(189, 20);
            this.txt_Port.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "Şifre:";
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(119, 68);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Properties.MaxLength = 50;
            this.txt_Password.Properties.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(189, 20);
            this.txt_Password.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Sunucu:";
            // 
            // txt_Server
            // 
            this.txt_Server.Location = new System.Drawing.Point(119, 97);
            this.txt_Server.Name = "txt_Server";
            this.txt_Server.Properties.MaxLength = 30;
            this.txt_Server.Size = new System.Drawing.Size(189, 20);
            this.txt_Server.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "E-Mail:";
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(119, 6);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Properties.MaxLength = 50;
            this.txt_Email.Size = new System.Drawing.Size(189, 20);
            this.txt_Email.TabIndex = 0;
            // 
            // MailSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 324);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_recipientEmail);
            this.Controls.Add(this.btn_SendMail);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.chk_SSL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Port);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Server);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Email);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("MailSettings.IconOptions.Image")));
            this.MaximizeBox = false;
            this.Name = "MailSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mail Ayarları";
            this.Load += new System.EventHandler(this.MailSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_recipientEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Port.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Password.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Server.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Email.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.TextEdit txt_recipientEmail;
        private DevExpress.XtraEditors.SimpleButton btn_SendMail;
        private DevExpress.XtraEditors.SimpleButton btn_Update;
        private System.Windows.Forms.CheckBox chk_SSL;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txt_Port;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit txt_Password;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit txt_Server;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txt_Email;
    }
}