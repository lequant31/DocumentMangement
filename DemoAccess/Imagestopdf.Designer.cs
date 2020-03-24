namespace DemoAccess
{
    partial class Imagestopdf
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Imagestopdf));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.Radiohuonggiay = new DevExpress.XtraEditors.RadioGroup();
            this.ListFile = new DevExpress.XtraEditors.ListBoxControl();
            this.BtnSaveasFile = new DevExpress.XtraEditors.SimpleButton();
            this.btnOpenFile = new DevExpress.XtraEditors.SimpleButton();
            this.TxtSaveasFile = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Radiohuonggiay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSaveasFile.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.layoutControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(398, 168);
            this.panelControl1.TabIndex = 0;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.Radiohuonggiay);
            this.layoutControl1.Controls.Add(this.ListFile);
            this.layoutControl1.Controls.Add(this.BtnSaveasFile);
            this.layoutControl1.Controls.Add(this.btnOpenFile);
            this.layoutControl1.Controls.Add(this.TxtSaveasFile);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(2, 2);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(394, 164);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // Radiohuonggiay
            // 
            this.Radiohuonggiay.EditValue = true;
            this.Radiohuonggiay.Location = new System.Drawing.Point(92, 94);
            this.Radiohuonggiay.Margin = new System.Windows.Forms.Padding(0);
            this.Radiohuonggiay.Name = "Radiohuonggiay";
            this.Radiohuonggiay.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.Radiohuonggiay.Properties.Appearance.Options.UseBackColor = true;
            this.Radiohuonggiay.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.Radiohuonggiay.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(true, "Giấy dọc"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(false, "Giấy ngang")});
            this.Radiohuonggiay.Size = new System.Drawing.Size(292, 34);
            this.Radiohuonggiay.StyleController = this.layoutControl1;
            this.Radiohuonggiay.TabIndex = 9;
            // 
            // ListFile
            // 
            this.ListFile.Location = new System.Drawing.Point(94, 12);
            this.ListFile.Name = "ListFile";
            this.ListFile.Size = new System.Drawing.Size(288, 56);
            this.ListFile.StyleController = this.layoutControl1;
            this.ListFile.TabIndex = 8;
            // 
            // BtnSaveasFile
            // 
            this.BtnSaveasFile.Location = new System.Drawing.Point(198, 130);
            this.BtnSaveasFile.Name = "BtnSaveasFile";
            this.BtnSaveasFile.Size = new System.Drawing.Size(184, 22);
            this.BtnSaveasFile.StyleController = this.layoutControl1;
            this.BtnSaveasFile.TabIndex = 7;
            this.BtnSaveasFile.Text = "Lưu File";
            this.BtnSaveasFile.Click += new System.EventHandler(this.BtnSaveasFile_Click);
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(12, 130);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(182, 22);
            this.btnOpenFile.StyleController = this.layoutControl1;
            this.btnOpenFile.TabIndex = 6;
            this.btnOpenFile.Text = "Mở File";
            this.btnOpenFile.Click += new System.EventHandler(this.BtnOpenFile_Click);
            // 
            // TxtSaveasFile
            // 
            this.TxtSaveasFile.Location = new System.Drawing.Point(94, 72);
            this.TxtSaveasFile.Name = "TxtSaveasFile";
            this.TxtSaveasFile.Size = new System.Drawing.Size(288, 20);
            this.TxtSaveasFile.StyleController = this.layoutControl1;
            this.TxtSaveasFile.TabIndex = 5;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem1,
            this.layoutControlItem5});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(394, 164);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.TxtSaveasFile;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 60);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(374, 24);
            this.layoutControlItem2.Text = "Tên cần lưu";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(79, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnOpenFile;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 118);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(186, 26);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.BtnSaveasFile;
            this.layoutControlItem4.Location = new System.Drawing.Point(186, 118);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(188, 26);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.ListFile;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(374, 60);
            this.layoutControlItem1.Text = "Danh sách File";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(79, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.Radiohuonggiay;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 84);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlItem5.Size = new System.Drawing.Size(374, 34);
            this.layoutControlItem5.Text = "Định hướng giấy";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(79, 13);
            // 
            // Imagestopdf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 168);
            this.Controls.Add(this.panelControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(408, 200);
            this.MinimumSize = new System.Drawing.Size(408, 200);
            this.Name = "Imagestopdf";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Convert Images to Pdf";
            this.Load += new System.EventHandler(this.Imagestopdf_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Radiohuonggiay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSaveasFile.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.SimpleButton BtnSaveasFile;
        private DevExpress.XtraEditors.SimpleButton btnOpenFile;
        private DevExpress.XtraEditors.TextEdit TxtSaveasFile;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.ListBoxControl ListFile;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.RadioGroup Radiohuonggiay;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
    }
}