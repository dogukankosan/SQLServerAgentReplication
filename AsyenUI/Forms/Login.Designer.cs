﻿
namespace AsyenUI.Forms
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.btn_Login = new DevExpress.XtraEditors.SimpleButton();
            this.btn_NotEye = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Eye = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Password = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_LoginName = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Password.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_LoginName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Login
            // 
            this.btn_Login.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success;
            this.btn_Login.Appearance.Font = new System.Drawing.Font("Tahoma", 18.25F);
            this.btn_Login.Appearance.Options.UseBackColor = true;
            this.btn_Login.Appearance.Options.UseFont = true;
            this.btn_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Login.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_Login.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Login.ImageOptions.Image")));
            this.btn_Login.Location = new System.Drawing.Point(0, 89);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(318, 38);
            this.btn_Login.TabIndex = 2;
            this.btn_Login.Text = "Giriş Yap";
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // btn_NotEye
            // 
            this.btn_NotEye.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btn_NotEye.Appearance.Options.UseBackColor = true;
            this.btn_NotEye.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_NotEye.ImageOptions.Image")));
            this.btn_NotEye.Location = new System.Drawing.Point(83, 43);
            this.btn_NotEye.Name = "btn_NotEye";
            this.btn_NotEye.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_NotEye.Size = new System.Drawing.Size(35, 20);
            this.btn_NotEye.TabIndex = 17;
            this.btn_NotEye.Click += new System.EventHandler(this.btn_NotEye_Click);
            // 
            // btn_Eye
            // 
            this.btn_Eye.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btn_Eye.Appearance.Options.UseBackColor = true;
            this.btn_Eye.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Eye.ImageOptions.Image")));
            this.btn_Eye.Location = new System.Drawing.Point(84, 43);
            this.btn_Eye.Name = "btn_Eye";
            this.btn_Eye.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_Eye.Size = new System.Drawing.Size(34, 20);
            this.btn_Eye.TabIndex = 16;
            this.btn_Eye.Click += new System.EventHandler(this.btn_Eye_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.label3.Location = new System.Drawing.Point(12, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 21);
            this.label3.TabIndex = 18;
            this.label3.Text = "Şifre:";
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(124, 40);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Properties.MaxLength = 30;
            this.txt_Password.Properties.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(167, 20);
            this.txt_Password.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.label2.Location = new System.Drawing.Point(12, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 21);
            this.label2.TabIndex = 15;
            this.label2.Text = "Kullanıcı Adı:";
            // 
            // txt_LoginName
            // 
            this.txt_LoginName.Location = new System.Drawing.Point(124, 7);
            this.txt_LoginName.Name = "txt_LoginName";
            this.txt_LoginName.Properties.MaxLength = 20;
            this.txt_LoginName.Size = new System.Drawing.Size(167, 20);
            this.txt_LoginName.TabIndex = 0;
            // 
            // Login
            // 
            this.AcceptButton = this.btn_Login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(318, 127);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.btn_NotEye);
            this.Controls.Add(this.btn_Eye);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_LoginName);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("Login.IconOptions.Image")));
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Ekranı";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_Password.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_LoginName.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btn_Login;
        private DevExpress.XtraEditors.SimpleButton btn_NotEye;
        private DevExpress.XtraEditors.SimpleButton btn_Eye;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit txt_Password;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txt_LoginName;
    }
}