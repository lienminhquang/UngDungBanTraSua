namespace DXApplication1
{
    partial class frm_DoiMatKhau
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_mk_moi2 = new DevExpress.XtraEditors.TextEdit();
            this.txt_mk_moi = new DevExpress.XtraEditors.TextEdit();
            this.txt_mk_cu = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_mk_moi2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_mk_moi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_mk_cu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.button2);
            this.layoutControl1.Controls.Add(this.button1);
            this.layoutControl1.Controls.Add(this.txt_mk_moi2);
            this.layoutControl1.Controls.Add(this.txt_mk_moi);
            this.layoutControl1.Controls.Add(this.txt_mk_cu);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(591, 221);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(297, 138);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.button2.Size = new System.Drawing.Size(282, 61);
            this.button2.TabIndex = 8;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 138);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.button1.Size = new System.Drawing.Size(281, 61);
            this.button1.TabIndex = 7;
            this.button1.Text = "Lưu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_mk_moi2
            // 
            this.txt_mk_moi2.Location = new System.Drawing.Point(169, 104);
            this.txt_mk_moi2.Name = "txt_mk_moi2";
            this.txt_mk_moi2.Properties.PasswordChar = '*';
            this.txt_mk_moi2.Size = new System.Drawing.Size(402, 22);
            this.txt_mk_moi2.StyleController = this.layoutControl1;
            this.txt_mk_moi2.TabIndex = 6;
            // 
            // txt_mk_moi
            // 
            this.txt_mk_moi.Location = new System.Drawing.Point(169, 62);
            this.txt_mk_moi.Name = "txt_mk_moi";
            this.txt_mk_moi.Properties.PasswordChar = '*';
            this.txt_mk_moi.Size = new System.Drawing.Size(402, 22);
            this.txt_mk_moi.StyleController = this.layoutControl1;
            this.txt_mk_moi.TabIndex = 5;
            // 
            // txt_mk_cu
            // 
            this.txt_mk_cu.Location = new System.Drawing.Point(169, 20);
            this.txt_mk_cu.Name = "txt_mk_cu";
            this.txt_mk_cu.Properties.PasswordChar = '*';
            this.txt_mk_cu.Size = new System.Drawing.Size(402, 22);
            this.txt_mk_cu.StyleController = this.layoutControl1;
            this.txt_mk_cu.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.emptySpaceItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(591, 221);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txt_mk_cu;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.layoutControlItem1.Size = new System.Drawing.Size(571, 42);
            this.layoutControlItem1.Text = "Nhập mật khẩu hiện tại:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(146, 17);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 191);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(571, 10);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txt_mk_moi;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 42);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.layoutControlItem2.Size = new System.Drawing.Size(571, 42);
            this.layoutControlItem2.Text = "Mật khẩu mới:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(146, 17);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txt_mk_moi2;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 84);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.layoutControlItem3.Size = new System.Drawing.Size(571, 42);
            this.layoutControlItem3.Text = "Nhập lại mật khẩu:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(146, 17);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.button1;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 126);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(285, 65);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.button2;
            this.layoutControlItem5.Location = new System.Drawing.Point(285, 126);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(286, 65);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // frm_DoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 221);
            this.Controls.Add(this.layoutControl1);
            this.Name = "frm_DoiMatKhau";
            this.Text = "Đổi mật khẩu";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_mk_moi2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_mk_moi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_mk_cu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private DevExpress.XtraEditors.TextEdit txt_mk_moi2;
        private DevExpress.XtraEditors.TextEdit txt_mk_moi;
        private DevExpress.XtraEditors.TextEdit txt_mk_cu;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
    }
}