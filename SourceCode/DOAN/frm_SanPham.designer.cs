namespace DXApplication1
{
    partial class frm_SanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_SanPham));
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiPrintPreview = new DevExpress.XtraBars.BarButtonItem();
            this.bsiRecordsCount = new DevExpress.XtraBars.BarStaticItem();
            this.btn_Them = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Sua = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Xoa = new DevExpress.XtraBars.BarButtonItem();
            this.btn_TaiLai = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Luu = new DevExpress.XtraBars.BarButtonItem();
            this.btn_NhapHang = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.rtxt_GhiChu = new System.Windows.Forms.RichTextBox();
            this.rtxt_ChiTiet = new System.Windows.Forms.RichTextBox();
            this.nud_GiaBan = new System.Windows.Forms.NumericUpDown();
            this.nud_SoLuong = new System.Windows.Forms.NumericUpDown();
            this.buttonEdit1 = new DevExpress.XtraEditors.ButtonEdit();
            this.txt_Ma = new DevExpress.XtraEditors.TextEdit();
            this.txt_Ten = new DevExpress.XtraEditors.TextEdit();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.txt_Loai = new System.Windows.Forms.ComboBox();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_GiaBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_SoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Ma.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Ten.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridControl1);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 342);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1231, 377);
            this.groupControl2.TabIndex = 11;
            this.groupControl2.Text = "Danh sách sản phẩm";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 25);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.ribbonControl;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1227, 350);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.bbiPrintPreview,
            this.bsiRecordsCount,
            this.btn_Them,
            this.btn_Sua,
            this.btn_Xoa,
            this.btn_TaiLai,
            this.btn_Luu,
            this.btn_NhapHang});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ribbonControl.MaxItemId = 22;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.Size = new System.Drawing.Size(1231, 145);
            this.ribbonControl.StatusBar = this.ribbonStatusBar;
            this.ribbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // bbiPrintPreview
            // 
            this.bbiPrintPreview.Caption = "Print Preview";
            this.bbiPrintPreview.Id = 14;
            this.bbiPrintPreview.ImageOptions.ImageUri.Uri = "Preview";
            this.bbiPrintPreview.Name = "bbiPrintPreview";
            // 
            // bsiRecordsCount
            // 
            this.bsiRecordsCount.Caption = "RECORDS : 0";
            this.bsiRecordsCount.Id = 15;
            this.bsiRecordsCount.Name = "bsiRecordsCount";
            // 
            // btn_Them
            // 
            this.btn_Them.Caption = "Thêm";
            this.btn_Them.Id = 16;
            this.btn_Them.ImageOptions.ImageUri.Uri = "New";
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiNew_ItemClick);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Caption = "Sửa";
            this.btn_Sua.Id = 17;
            this.btn_Sua.ImageOptions.ImageUri.Uri = "Edit";
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiEdit_ItemClick);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Caption = "Xóa";
            this.btn_Xoa.Id = 18;
            this.btn_Xoa.ImageOptions.ImageUri.Uri = "Delete";
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Xoa_ItemClick);
            // 
            // btn_TaiLai
            // 
            this.btn_TaiLai.Caption = "Tải lại";
            this.btn_TaiLai.Id = 19;
            this.btn_TaiLai.ImageOptions.ImageUri.Uri = "Refresh";
            this.btn_TaiLai.Name = "btn_TaiLai";
            this.btn_TaiLai.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_TaiLai_ItemClick);
            // 
            // btn_Luu
            // 
            this.btn_Luu.Caption = "Lưu";
            this.btn_Luu.Id = 20;
            this.btn_Luu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Luu.ImageOptions.Image")));
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btn_Luu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Luu_ItemClick);
            // 
            // btn_NhapHang
            // 
            this.btn_NhapHang.Caption = "Nhập hàng";
            this.btn_NhapHang.Id = 21;
            this.btn_NhapHang.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_NhapHang.ImageOptions.Image")));
            this.btn_NhapHang.Name = "btn_NhapHang";
            this.btn_NhapHang.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btn_NhapHang.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.MergeOrder = 0;
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Home";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_Them);
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_Sua);
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_Xoa);
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_Luu);
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_TaiLai);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "Tasks";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.AllowTextClipping = false;
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_NhapHang);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            this.ribbonPageGroup2.Text = "Tùy chọn";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.bsiRecordsCount);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 719);
            this.ribbonStatusBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbonControl;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1231, 34);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.layoutControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 145);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1231, 197);
            this.groupControl1.TabIndex = 10;
            this.groupControl1.Text = "Thông tin chi tiết";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txt_Loai);
            this.layoutControl1.Controls.Add(this.rtxt_GhiChu);
            this.layoutControl1.Controls.Add(this.rtxt_ChiTiet);
            this.layoutControl1.Controls.Add(this.nud_GiaBan);
            this.layoutControl1.Controls.Add(this.nud_SoLuong);
            this.layoutControl1.Controls.Add(this.buttonEdit1);
            this.layoutControl1.Controls.Add(this.txt_Ma);
            this.layoutControl1.Controls.Add(this.txt_Ten);
            this.layoutControl1.Controls.Add(this.pictureEdit1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(2, 25);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1227, 170);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // rtxt_GhiChu
            // 
            this.rtxt_GhiChu.Location = new System.Drawing.Point(870, 89);
            this.rtxt_GhiChu.Name = "rtxt_GhiChu";
            this.rtxt_GhiChu.Size = new System.Drawing.Size(345, 66);
            this.rtxt_GhiChu.TabIndex = 17;
            this.rtxt_GhiChu.Text = "";
            // 
            // rtxt_ChiTiet
            // 
            this.rtxt_ChiTiet.Location = new System.Drawing.Point(362, 108);
            this.rtxt_ChiTiet.Name = "rtxt_ChiTiet";
            this.rtxt_ChiTiet.Size = new System.Drawing.Size(388, 47);
            this.rtxt_ChiTiet.TabIndex = 16;
            this.rtxt_ChiTiet.Text = "";
            // 
            // nud_GiaBan
            // 
            this.nud_GiaBan.Location = new System.Drawing.Point(362, 76);
            this.nud_GiaBan.Name = "nud_GiaBan";
            this.nud_GiaBan.Size = new System.Drawing.Size(390, 23);
            this.nud_GiaBan.TabIndex = 14;
            // 
            // nud_SoLuong
            // 
            this.nud_SoLuong.Location = new System.Drawing.Point(870, 52);
            this.nud_SoLuong.Name = "nud_SoLuong";
            this.nud_SoLuong.Size = new System.Drawing.Size(347, 23);
            this.nud_SoLuong.TabIndex = 13;
            // 
            // buttonEdit1
            // 
            this.buttonEdit1.Location = new System.Drawing.Point(80, 136);
            this.buttonEdit1.MenuManager = this.ribbonControl;
            this.buttonEdit1.Name = "buttonEdit1";
            this.buttonEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.buttonEdit1.Size = new System.Drawing.Size(162, 22);
            this.buttonEdit1.StyleController = this.layoutControl1;
            this.buttonEdit1.TabIndex = 12;
            // 
            // txt_Ma
            // 
            this.txt_Ma.Location = new System.Drawing.Point(870, 12);
            this.txt_Ma.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.txt_Ma.MenuManager = this.ribbonControl;
            this.txt_Ma.Name = "txt_Ma";
            this.txt_Ma.Size = new System.Drawing.Size(347, 22);
            this.txt_Ma.StyleController = this.layoutControl1;
            this.txt_Ma.TabIndex = 6;
            // 
            // txt_Ten
            // 
            this.txt_Ten.Location = new System.Drawing.Point(362, 12);
            this.txt_Ten.MenuManager = this.ribbonControl;
            this.txt_Ten.Name = "txt_Ten";
            this.txt_Ten.Size = new System.Drawing.Size(388, 22);
            this.txt_Ten.StyleController = this.layoutControl1;
            this.txt_Ten.TabIndex = 5;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Location = new System.Drawing.Point(12, 12);
            this.pictureEdit1.MenuManager = this.ribbonControl;
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Size = new System.Drawing.Size(230, 120);
            this.pictureEdit1.StyleController = this.layoutControl1;
            this.pictureEdit1.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem8,
            this.layoutControlItem6,
            this.layoutControlItem5,
            this.layoutControlItem4,
            this.layoutControlItem7,
            this.layoutControlItem10});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1227, 170);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.pictureEdit1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(234, 124);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txt_Ten;
            this.layoutControlItem2.Location = new System.Drawing.Point(234, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.OptionsTableLayoutItem.ColumnIndex = 1;
            this.layoutControlItem2.Padding = new DevExpress.XtraLayout.Utils.Padding(50, 2, 2, 2);
            this.layoutControlItem2.Size = new System.Drawing.Size(508, 34);
            this.layoutControlItem2.Text = "Tên: ";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(65, 16);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txt_Ma;
            this.layoutControlItem3.Location = new System.Drawing.Point(742, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.OptionsTableLayoutItem.RowIndex = 1;
            this.layoutControlItem3.Padding = new DevExpress.XtraLayout.Utils.Padding(50, 0, 2, 10);
            this.layoutControlItem3.Size = new System.Drawing.Size(465, 34);
            this.layoutControlItem3.Text = "Mã:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(65, 16);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.buttonEdit1;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 124);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(234, 26);
            this.layoutControlItem8.Text = "Chọn ảnh:";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(65, 17);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.nud_SoLuong;
            this.layoutControlItem6.Location = new System.Drawing.Point(742, 34);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Padding = new DevExpress.XtraLayout.Utils.Padding(50, 0, 8, 2);
            this.layoutControlItem6.Size = new System.Drawing.Size(465, 35);
            this.layoutControlItem6.Text = "Số lượng:";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(65, 17);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.nud_GiaBan;
            this.layoutControlItem5.Location = new System.Drawing.Point(234, 64);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Padding = new DevExpress.XtraLayout.Utils.Padding(50, 0, 2, 2);
            this.layoutControlItem5.Size = new System.Drawing.Size(508, 29);
            this.layoutControlItem5.Text = "Giá bán:";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(65, 16);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.rtxt_ChiTiet;
            this.layoutControlItem4.Location = new System.Drawing.Point(234, 93);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Padding = new DevExpress.XtraLayout.Utils.Padding(50, 2, 5, 5);
            this.layoutControlItem4.Size = new System.Drawing.Size(508, 57);
            this.layoutControlItem4.Text = "Chi tiết:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(65, 17);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.rtxt_GhiChu;
            this.layoutControlItem7.Location = new System.Drawing.Point(742, 69);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Padding = new DevExpress.XtraLayout.Utils.Padding(50, 2, 10, 5);
            this.layoutControlItem7.Size = new System.Drawing.Size(465, 81);
            this.layoutControlItem7.Text = "Ghi chú:";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(65, 16);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Lưu";
            this.barButtonItem2.Id = 20;
            this.barButtonItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // txt_Loai
            // 
            this.txt_Loai.FormattingEnabled = true;
            this.txt_Loai.Location = new System.Drawing.Point(362, 46);
            this.txt_Loai.Name = "txt_Loai";
            this.txt_Loai.Size = new System.Drawing.Size(388, 24);
            this.txt_Loai.TabIndex = 18;
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.txt_Loai;
            this.layoutControlItem10.Location = new System.Drawing.Point(234, 34);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Padding = new DevExpress.XtraLayout.Utils.Padding(50, 2, 2, 2);
            this.layoutControlItem10.Size = new System.Drawing.Size(508, 30);
            this.layoutControlItem10.Text = "Loai:";
            this.layoutControlItem10.TextSize = new System.Drawing.Size(65, 16);
            // 
            // frm_SanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 753);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbonControl);
            this.Name = "frm_SanPham";
            this.Text = "Quản lý sản phẩm";
            this.Load += new System.EventHandler(this.frm_SanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nud_GiaBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_SoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Ma.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Ten.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.BarButtonItem bbiPrintPreview;
        private DevExpress.XtraBars.BarStaticItem bsiRecordsCount;
        private DevExpress.XtraBars.BarButtonItem btn_Them;
        private DevExpress.XtraBars.BarButtonItem btn_Sua;
        private DevExpress.XtraBars.BarButtonItem btn_Xoa;
        private DevExpress.XtraBars.BarButtonItem btn_TaiLai;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.ButtonEdit buttonEdit1;
        private DevExpress.XtraEditors.TextEdit txt_Ma;
        private DevExpress.XtraEditors.TextEdit txt_Ten;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private System.Windows.Forms.NumericUpDown nud_GiaBan;
        private System.Windows.Forms.NumericUpDown nud_SoLuong;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraBars.BarButtonItem btn_Luu;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem btn_NhapHang;
        private System.Windows.Forms.RichTextBox rtxt_GhiChu;
        private System.Windows.Forms.RichTextBox rtxt_ChiTiet;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private System.Windows.Forms.ComboBox txt_Loai;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
    }
}