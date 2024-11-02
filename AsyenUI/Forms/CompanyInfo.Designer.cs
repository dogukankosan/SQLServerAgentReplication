
namespace AsyenUI.Forms
{
    partial class CompanyInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompanyInfo));
            this.btn_Save = new DevExpress.XtraEditors.SimpleButton();
            this.txt_TableInfo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_CompanyName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Save
            // 
            this.btn_Save.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success;
            this.btn_Save.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.btn_Save.Appearance.Options.UseBackColor = true;
            this.btn_Save.Appearance.Options.UseFont = true;
            this.btn_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Save.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_Save.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Save.ImageOptions.Image")));
            this.btn_Save.Location = new System.Drawing.Point(0, 109);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(252, 45);
            this.btn_Save.TabIndex = 2;
            this.btn_Save.Text = "KAYDET";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // txt_TableInfo
            // 
            this.txt_TableInfo.Location = new System.Drawing.Point(10, 25);
            this.txt_TableInfo.Name = "txt_TableInfo";
            this.txt_TableInfo.Size = new System.Drawing.Size(128, 21);
            this.txt_TableInfo.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(7, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tablo Ön Takı:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_CompanyName
            // 
            this.txt_CompanyName.Location = new System.Drawing.Point(12, 67);
            this.txt_CompanyName.Name = "txt_CompanyName";
            this.txt_CompanyName.Size = new System.Drawing.Size(126, 21);
            this.txt_CompanyName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Firma Adı:";
            // 
            // CompanyInfo
            // 
            this.AcceptButton = this.btn_Save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 154);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_CompanyName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_TableInfo);
            this.Controls.Add(this.btn_Save);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("CompanyInfo.IconOptions.Image")));
            this.MaximizeBox = false;
            this.Name = "CompanyInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Şirket Bilgileri Ayarları";
            this.Load += new System.EventHandler(this.CompanyInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btn_Save;
        private System.Windows.Forms.TextBox txt_TableInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_CompanyName;
        private System.Windows.Forms.Label label1;
    }
}