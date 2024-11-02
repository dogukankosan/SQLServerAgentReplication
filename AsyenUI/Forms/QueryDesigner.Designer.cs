
namespace AsyenUI.Forms
{
    partial class QueryDesigner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QueryDesigner));
            this.rch_Query = new System.Windows.Forms.RichTextBox();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.chk_Monday = new System.Windows.Forms.CheckBox();
            this.chk_Tuesday = new System.Windows.Forms.CheckBox();
            this.chk_Sunday = new System.Windows.Forms.CheckBox();
            this.chk_Wednesday = new System.Windows.Forms.CheckBox();
            this.chk_Saturday = new System.Windows.Forms.CheckBox();
            this.chk_Thursday = new System.Windows.Forms.CheckBox();
            this.chk_Friday = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_QueryName = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Hour = new DevExpress.XtraEditors.TextEdit();
            this.btn_Save = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.tmt_Startdate = new DevExpress.XtraEditors.TimeEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_QueryName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Hour.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tmt_Startdate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // rch_Query
            // 
            this.rch_Query.Dock = System.Windows.Forms.DockStyle.Left;
            this.rch_Query.Location = new System.Drawing.Point(0, 0);
            this.rch_Query.Name = "rch_Query";
            this.rch_Query.Size = new System.Drawing.Size(364, 412);
            this.rch_Query.TabIndex = 0;
            this.rch_Query.Text = "";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.chk_Monday);
            this.groupControl1.Controls.Add(this.chk_Tuesday);
            this.groupControl1.Controls.Add(this.chk_Sunday);
            this.groupControl1.Controls.Add(this.chk_Wednesday);
            this.groupControl1.Controls.Add(this.chk_Saturday);
            this.groupControl1.Controls.Add(this.chk_Thursday);
            this.groupControl1.Controls.Add(this.chk_Friday);
            this.groupControl1.Location = new System.Drawing.Point(373, 108);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(246, 97);
            this.groupControl1.TabIndex = 12;
            this.groupControl1.Text = "İşlem Yapılacak Günler";
            // 
            // chk_Monday
            // 
            this.chk_Monday.AutoSize = true;
            this.chk_Monday.Location = new System.Drawing.Point(5, 26);
            this.chk_Monday.Name = "chk_Monday";
            this.chk_Monday.Size = new System.Drawing.Size(70, 17);
            this.chk_Monday.TabIndex = 3;
            this.chk_Monday.Text = "Pazartesi";
            this.chk_Monday.UseVisualStyleBackColor = true;
            // 
            // chk_Tuesday
            // 
            this.chk_Tuesday.AutoSize = true;
            this.chk_Tuesday.Location = new System.Drawing.Point(81, 26);
            this.chk_Tuesday.Name = "chk_Tuesday";
            this.chk_Tuesday.Size = new System.Drawing.Size(42, 17);
            this.chk_Tuesday.TabIndex = 4;
            this.chk_Tuesday.Text = "Salı";
            this.chk_Tuesday.UseVisualStyleBackColor = true;
            // 
            // chk_Sunday
            // 
            this.chk_Sunday.AutoSize = true;
            this.chk_Sunday.Location = new System.Drawing.Point(5, 72);
            this.chk_Sunday.Name = "chk_Sunday";
            this.chk_Sunday.Size = new System.Drawing.Size(53, 17);
            this.chk_Sunday.TabIndex = 9;
            this.chk_Sunday.Text = "Pazar";
            this.chk_Sunday.UseVisualStyleBackColor = true;
            // 
            // chk_Wednesday
            // 
            this.chk_Wednesday.AutoSize = true;
            this.chk_Wednesday.Location = new System.Drawing.Point(157, 26);
            this.chk_Wednesday.Name = "chk_Wednesday";
            this.chk_Wednesday.Size = new System.Drawing.Size(74, 17);
            this.chk_Wednesday.TabIndex = 5;
            this.chk_Wednesday.Text = "Çarşamba";
            this.chk_Wednesday.UseVisualStyleBackColor = true;
            // 
            // chk_Saturday
            // 
            this.chk_Saturday.AutoSize = true;
            this.chk_Saturday.Location = new System.Drawing.Point(157, 49);
            this.chk_Saturday.Name = "chk_Saturday";
            this.chk_Saturday.Size = new System.Drawing.Size(74, 17);
            this.chk_Saturday.TabIndex = 8;
            this.chk_Saturday.Text = "Cumartesi";
            this.chk_Saturday.UseVisualStyleBackColor = true;
            // 
            // chk_Thursday
            // 
            this.chk_Thursday.AutoSize = true;
            this.chk_Thursday.Location = new System.Drawing.Point(5, 49);
            this.chk_Thursday.Name = "chk_Thursday";
            this.chk_Thursday.Size = new System.Drawing.Size(73, 17);
            this.chk_Thursday.TabIndex = 6;
            this.chk_Thursday.Text = "Perşembe";
            this.chk_Thursday.UseVisualStyleBackColor = true;
            // 
            // chk_Friday
            // 
            this.chk_Friday.AutoSize = true;
            this.chk_Friday.Location = new System.Drawing.Point(81, 49);
            this.chk_Friday.Name = "chk_Friday";
            this.chk_Friday.Size = new System.Drawing.Size(53, 17);
            this.chk_Friday.TabIndex = 7;
            this.chk_Friday.Text = "Cuma";
            this.chk_Friday.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(370, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Sorgu Adı:";
            // 
            // txt_QueryName
            // 
            this.txt_QueryName.Location = new System.Drawing.Point(497, 6);
            this.txt_QueryName.Name = "txt_QueryName";
            this.txt_QueryName.Properties.MaxLength = 50;
            this.txt_QueryName.Size = new System.Drawing.Size(122, 20);
            this.txt_QueryName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(370, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Kaç Saate Bir Çalışacak:";
            // 
            // txt_Hour
            // 
            this.txt_Hour.Location = new System.Drawing.Point(497, 66);
            this.txt_Hour.Name = "txt_Hour";
            this.txt_Hour.Properties.MaxLength = 2;
            this.txt_Hour.Size = new System.Drawing.Size(122, 20);
            this.txt_Hour.TabIndex = 2;
            this.txt_Hour.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Hour_KeyPress);
            // 
            // btn_Save
            // 
            this.btn_Save.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success;
            this.btn_Save.Appearance.Font = new System.Drawing.Font("Tahoma", 18.25F);
            this.btn_Save.Appearance.Options.UseBackColor = true;
            this.btn_Save.Appearance.Options.UseFont = true;
            this.btn_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Save.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_Save.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Save.ImageOptions.Image")));
            this.btn_Save.Location = new System.Drawing.Point(364, 354);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(267, 58);
            this.btn_Save.TabIndex = 10;
            this.btn_Save.Text = "Kaydet";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(370, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Başlangıç Saati:";
            // 
            // tmt_Startdate
            // 
            this.tmt_Startdate.EditValue = new System.DateTime(2024, 9, 7, 0, 0, 0, 0);
            this.tmt_Startdate.Location = new System.Drawing.Point(497, 37);
            this.tmt_Startdate.Name = "tmt_Startdate";
            this.tmt_Startdate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tmt_Startdate.Size = new System.Drawing.Size(119, 20);
            this.tmt_Startdate.TabIndex = 1;
            // 
            // QueryDesigner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(631, 412);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tmt_Startdate);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Hour);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_QueryName);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.rch_Query);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("QueryDesigner.IconOptions.Image")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "QueryDesigner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sorguyu Düzenle";
            this.Load += new System.EventHandler(this.QueryDesigner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_QueryName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Hour.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tmt_Startdate.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rch_Query;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.CheckBox chk_Monday;
        private System.Windows.Forms.CheckBox chk_Tuesday;
        private System.Windows.Forms.CheckBox chk_Sunday;
        private System.Windows.Forms.CheckBox chk_Wednesday;
        private System.Windows.Forms.CheckBox chk_Saturday;
        private System.Windows.Forms.CheckBox chk_Thursday;
        private System.Windows.Forms.CheckBox chk_Friday;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txt_QueryName;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txt_Hour;
        private DevExpress.XtraEditors.SimpleButton btn_Save;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TimeEdit tmt_Startdate;
    }
}