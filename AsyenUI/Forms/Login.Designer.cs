
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
            this.txt_Username = new DevExpress.XtraEditors.TextEdit();
            this.txt_Pass = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Save = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Eyes = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Noteyes = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Username.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Pass.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Username
            // 
            this.txt_Username.Location = new System.Drawing.Point(111, 6);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Properties.MaxLength = 50;
            this.txt_Username.Size = new System.Drawing.Size(177, 20);
            this.txt_Username.TabIndex = 0;
            // 
            // txt_Pass
            // 
            this.txt_Pass.Location = new System.Drawing.Point(111, 47);
            this.txt_Pass.Name = "txt_Pass";
            this.txt_Pass.Properties.MaxLength = 50;
            this.txt_Pass.Properties.PasswordChar = '*';
            this.txt_Pass.Size = new System.Drawing.Size(177, 20);
            this.txt_Pass.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Şifre:";
            // 
            // btn_Save
            // 
            this.btn_Save.Appearance.BackColor = System.Drawing.Color.Red;
            this.btn_Save.Appearance.Font = new System.Drawing.Font("Tahoma", 15.25F);
            this.btn_Save.Appearance.ForeColor = System.Drawing.Color.White;
            this.btn_Save.Appearance.Options.UseBackColor = true;
            this.btn_Save.Appearance.Options.UseFont = true;
            this.btn_Save.Appearance.Options.UseForeColor = true;
            this.btn_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Save.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_Save.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Save.ImageOptions.Image")));
            this.btn_Save.Location = new System.Drawing.Point(0, 95);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(314, 53);
            this.btn_Save.TabIndex = 3;
            this.btn_Save.Text = "ATEŞLE";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Eyes
            // 
            this.btn_Eyes.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Eyes.ImageOptions.Image")));
            this.btn_Eyes.Location = new System.Drawing.Point(67, 45);
            this.btn_Eyes.Name = "btn_Eyes";
            this.btn_Eyes.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_Eyes.Size = new System.Drawing.Size(38, 23);
            this.btn_Eyes.TabIndex = 4;
            this.btn_Eyes.Click += new System.EventHandler(this.btn_Eyes_Click);
            // 
            // btn_Noteyes
            // 
            this.btn_Noteyes.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Noteyes.ImageOptions.Image")));
            this.btn_Noteyes.Location = new System.Drawing.Point(67, 44);
            this.btn_Noteyes.Name = "btn_Noteyes";
            this.btn_Noteyes.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_Noteyes.Size = new System.Drawing.Size(38, 23);
            this.btn_Noteyes.TabIndex = 5;
            this.btn_Noteyes.Click += new System.EventHandler(this.btn_Noteyes_Click);
            // 
            // Login
            // 
            this.AcceptButton = this.btn_Save;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(314, 148);
            this.Controls.Add(this.btn_Noteyes);
            this.Controls.Add(this.btn_Eyes);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Pass);
            this.Controls.Add(this.txt_Username);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("Login.IconOptions.Image")));
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asyen Otomatik İşlemler Giriş Ekrani";
            this.Load += new System.EventHandler(this.Login_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.txt_Username.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Pass.Properties)).EndInit();
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
        private DevExpress.XtraEditors.TextEdit txt_Username;
        private DevExpress.XtraEditors.TextEdit txt_Pass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SimpleButton btn_Save;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton btn_Eyes;
        private DevExpress.XtraEditors.SimpleButton btn_Noteyes;
    }
}