namespace DXApplication1
{
    partial class frm_ThongTinTaiKhoan
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_DoiMK = new System.Windows.Forms.Button();
            this.txt_MK = new DevExpress.XtraEditors.TextEdit();
            this.txt_TenTK = new DevExpress.XtraEditors.TextEdit();
            this.txt_Ma = new DevExpress.XtraEditors.TextEdit();
            this.txt_Ten = new DevExpress.XtraEditors.TextEdit();
            this.img_ = new DevExpress.XtraEditors.PictureEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenTK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Ma.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Ten.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btn_Thoat);
            this.layoutControl1.Controls.Add(this.btn_DoiMK);
            this.layoutControl1.Controls.Add(this.txt_MK);
            this.layoutControl1.Controls.Add(this.txt_TenTK);
            this.layoutControl1.Controls.Add(this.txt_Ma);
            this.layoutControl1.Controls.Add(this.txt_Ten);
            this.layoutControl1.Controls.Add(this.img_);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(768, 256);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(499, 180);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(257, 64);
            this.btn_Thoat.TabIndex = 10;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btn_DoiMK
            // 
            this.btn_DoiMK.Location = new System.Drawing.Point(239, 180);
            this.btn_DoiMK.Name = "btn_DoiMK";
            this.btn_DoiMK.Size = new System.Drawing.Size(256, 64);
            this.btn_DoiMK.TabIndex = 9;
            this.btn_DoiMK.Text = "Đổi mật khẩu";
            this.btn_DoiMK.UseVisualStyleBackColor = true;
            this.btn_DoiMK.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_MK
            // 
            this.txt_MK.Location = new System.Drawing.Point(338, 146);
            this.txt_MK.Name = "txt_MK";
            this.txt_MK.Properties.PasswordChar = '*';
            this.txt_MK.Properties.ReadOnly = true;
            this.txt_MK.Size = new System.Drawing.Size(410, 22);
            this.txt_MK.StyleController = this.layoutControl1;
            this.txt_MK.TabIndex = 8;
            // 
            // txt_TenTK
            // 
            this.txt_TenTK.EditValue = "";
            this.txt_TenTK.Location = new System.Drawing.Point(338, 104);
            this.txt_TenTK.Name = "txt_TenTK";
            this.txt_TenTK.Properties.ReadOnly = true;
            this.txt_TenTK.Size = new System.Drawing.Size(410, 22);
            this.txt_TenTK.StyleController = this.layoutControl1;
            this.txt_TenTK.TabIndex = 7;
            // 
            // txt_Ma
            // 
            this.txt_Ma.Location = new System.Drawing.Point(338, 62);
            this.txt_Ma.Name = "txt_Ma";
            this.txt_Ma.Properties.ReadOnly = true;
            this.txt_Ma.Size = new System.Drawing.Size(410, 22);
            this.txt_Ma.StyleController = this.layoutControl1;
            this.txt_Ma.TabIndex = 6;
            // 
            // txt_Ten
            // 
            this.txt_Ten.Location = new System.Drawing.Point(338, 20);
            this.txt_Ten.Name = "txt_Ten";
            this.txt_Ten.Properties.ReadOnly = true;
            this.txt_Ten.Size = new System.Drawing.Size(410, 22);
            this.txt_Ten.StyleController = this.layoutControl1;
            this.txt_Ten.TabIndex = 5;
            // 
            // img_
            // 
            this.img_.Location = new System.Drawing.Point(12, 12);
            this.img_.Name = "img_";
            this.img_.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.img_.Size = new System.Drawing.Size(223, 232);
            this.img_.StyleController = this.layoutControl1;
            this.img_.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(768, 256);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.img_;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(227, 236);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txt_Ten;
            this.layoutControlItem2.Location = new System.Drawing.Point(227, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.layoutControlItem2.Size = new System.Drawing.Size(521, 42);
            this.layoutControlItem2.Text = "Tên nhân viên:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(88, 16);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txt_Ma;
            this.layoutControlItem3.Location = new System.Drawing.Point(227, 42);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.layoutControlItem3.Size = new System.Drawing.Size(521, 42);
            this.layoutControlItem3.Text = "Mã nhân viên:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(88, 16);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txt_TenTK;
            this.layoutControlItem4.Location = new System.Drawing.Point(227, 84);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.layoutControlItem4.Size = new System.Drawing.Size(521, 42);
            this.layoutControlItem4.Text = "Tên tài khoản:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(88, 17);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.txt_MK;
            this.layoutControlItem5.Location = new System.Drawing.Point(227, 126);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.layoutControlItem5.Size = new System.Drawing.Size(521, 42);
            this.layoutControlItem5.Text = "Mật khẩu:";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(88, 17);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.btn_DoiMK;
            this.layoutControlItem6.Location = new System.Drawing.Point(227, 168);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(260, 68);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.btn_Thoat;
            this.layoutControlItem7.Location = new System.Drawing.Point(487, 168);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(261, 68);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // frm_ThongTinTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 256);
            this.Controls.Add(this.layoutControl1);
            this.Name = "frm_ThongTinTaiKhoan";
            this.Text = "Thông tin tài khoản";
            this.Load += new System.EventHandler(this.frm_ThongTinTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_MK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenTK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Ma.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Ten.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_DoiMK;
        private DevExpress.XtraEditors.TextEdit txt_MK;
        private DevExpress.XtraEditors.TextEdit txt_TenTK;
        private DevExpress.XtraEditors.TextEdit txt_Ma;
        private DevExpress.XtraEditors.TextEdit txt_Ten;
        private DevExpress.XtraEditors.PictureEdit img_;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
    }
}