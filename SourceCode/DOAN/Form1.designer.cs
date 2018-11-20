namespace DXApplication1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.iExit = new DevExpress.XtraBars.BarButtonItem();
            this.iHelp = new DevExpress.XtraBars.BarButtonItem();
            this.iAbout = new DevExpress.XtraBars.BarButtonItem();
            this.siStatus = new DevExpress.XtraBars.BarStaticItem();
            this.siInfo = new DevExpress.XtraBars.BarStaticItem();
            this.rgbiSkins = new DevExpress.XtraBars.RibbonGalleryBarItem();
            this.btn_NhanVien = new DevExpress.XtraBars.BarButtonItem();
            this.btn_ThongTinTaiKhoan = new DevExpress.XtraBars.BarButtonItem();
            this.btn_DoiTaiKhoan = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Thoat = new DevExpress.XtraBars.BarButtonItem();
            this.btn_LoaiSanPham = new DevExpress.XtraBars.BarButtonItem();
            this.btn_SanPham = new DevExpress.XtraBars.BarButtonItem();
            this.btn_HoaDon = new DevExpress.XtraBars.BarButtonItem();
            this.btn_ChiTietHoaDon = new DevExpress.XtraBars.BarButtonItem();
            this.btn_ThayDoiServer = new DevExpress.XtraBars.BarButtonItem();
            this.btn_LoaiNhanVien = new DevExpress.XtraBars.BarButtonItem();
            this.btn_TaiKhoan = new DevExpress.XtraBars.BarButtonItem();
            this.fileRibbonPage1 = new DevExpress.XtraScheduler.UI.FileRibbonPage();
            this.commonRibbonPageGroup1 = new DevExpress.XtraScheduler.UI.CommonRibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.homeRibbonPage1 = new DevExpress.XtraScheduler.UI.HomeRibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.repositoryItemDuration1 = new DevExpress.XtraScheduler.UI.RepositoryItemDuration();
            this.repositoryItemSpinEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.saveScheduleItem2 = new DevExpress.XtraScheduler.UI.SaveScheduleItem();
            this.saveScheduleItem3 = new DevExpress.XtraScheduler.UI.SaveScheduleItem();
            this.saveScheduleItem4 = new DevExpress.XtraScheduler.UI.SaveScheduleItem();
            this.saveScheduleItem5 = new DevExpress.XtraScheduler.UI.SaveScheduleItem();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDuration1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.ApplicationButtonText = null;
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.iExit,
            this.iHelp,
            this.iAbout,
            this.siStatus,
            this.siInfo,
            this.rgbiSkins,
            this.btn_NhanVien,
            this.btn_ThongTinTaiKhoan,
            this.btn_DoiTaiKhoan,
            this.btn_Thoat,
            this.btn_LoaiSanPham,
            this.btn_SanPham,
            this.btn_HoaDon,
            this.btn_ChiTietHoaDon,
            this.btn_ThayDoiServer,
            this.btn_LoaiNhanVien,
            this.btn_TaiKhoan});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 120;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.PageHeaderItemLinks.Add(this.iAbout);
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.fileRibbonPage1,
            this.homeRibbonPage1,
            this.ribbonPage3});
            this.ribbonControl.QuickToolbarItemLinks.Add(this.iHelp);
            this.ribbonControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDuration1,
            this.repositoryItemSpinEdit1});
            this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.ribbonControl.Size = new System.Drawing.Size(1100, 178);
            this.ribbonControl.StatusBar = this.ribbonStatusBar;
            // 
            // iExit
            // 
            this.iExit.Caption = "Exit";
            this.iExit.Description = "Closes this program after prompting you to save unsaved data.";
            this.iExit.Hint = "Closes this program after prompting you to save unsaved data";
            this.iExit.Id = 20;
            this.iExit.ImageOptions.ImageIndex = 6;
            this.iExit.ImageOptions.LargeImageIndex = 6;
            this.iExit.Name = "iExit";
            // 
            // iHelp
            // 
            this.iHelp.Caption = "Help";
            this.iHelp.Description = "Start the program help system.";
            this.iHelp.Hint = "Start the program help system";
            this.iHelp.Id = 22;
            this.iHelp.ImageOptions.ImageIndex = 7;
            this.iHelp.ImageOptions.LargeImageIndex = 7;
            this.iHelp.Name = "iHelp";
            // 
            // iAbout
            // 
            this.iAbout.Caption = "About";
            this.iAbout.Description = "Displays general program information.";
            this.iAbout.Hint = "Displays general program information";
            this.iAbout.Id = 24;
            this.iAbout.ImageOptions.ImageIndex = 8;
            this.iAbout.ImageOptions.LargeImageIndex = 8;
            this.iAbout.Name = "iAbout";
            // 
            // siStatus
            // 
            this.siStatus.Caption = "Some Status Info";
            this.siStatus.Id = 31;
            this.siStatus.Name = "siStatus";
            // 
            // siInfo
            // 
            this.siInfo.Caption = "Some Info";
            this.siInfo.Id = 32;
            this.siInfo.Name = "siInfo";
            // 
            // rgbiSkins
            // 
            this.rgbiSkins.Caption = "Skins";
            // 
            // 
            // 
            this.rgbiSkins.Gallery.AllowHoverImages = true;
            this.rgbiSkins.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseFont = true;
            this.rgbiSkins.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseTextOptions = true;
            this.rgbiSkins.Gallery.Appearance.ItemCaptionAppearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.rgbiSkins.Gallery.ColumnCount = 4;
            this.rgbiSkins.Gallery.FixedHoverImageSize = false;
            this.rgbiSkins.Gallery.ImageSize = new System.Drawing.Size(32, 17);
            this.rgbiSkins.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Top;
            this.rgbiSkins.Gallery.RowCount = 4;
            this.rgbiSkins.Id = 60;
            this.rgbiSkins.Name = "rgbiSkins";
            // 
            // btn_NhanVien
            // 
            this.btn_NhanVien.Caption = "Nhân viên";
            this.btn_NhanVien.Id = 109;
            this.btn_NhanVien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_NhanVien.ImageOptions.Image")));
            this.btn_NhanVien.Name = "btn_NhanVien";
            this.btn_NhanVien.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btn_NhanVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_NhanVien_ItemClick);
            // 
            // btn_ThongTinTaiKhoan
            // 
            this.btn_ThongTinTaiKhoan.Caption = "Thông tin tài khoản";
            this.btn_ThongTinTaiKhoan.Id = 110;
            this.btn_ThongTinTaiKhoan.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_ThongTinTaiKhoan.ImageOptions.SvgImage")));
            this.btn_ThongTinTaiKhoan.Name = "btn_ThongTinTaiKhoan";
            this.btn_ThongTinTaiKhoan.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btn_ThongTinTaiKhoan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_ThongTinTaiKhoan_ItemClick);
            // 
            // btn_DoiTaiKhoan
            // 
            this.btn_DoiTaiKhoan.Caption = "Đổi tài khoản";
            this.btn_DoiTaiKhoan.Id = 111;
            this.btn_DoiTaiKhoan.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_DoiTaiKhoan.ImageOptions.SvgImage")));
            this.btn_DoiTaiKhoan.Name = "btn_DoiTaiKhoan";
            this.btn_DoiTaiKhoan.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btn_DoiTaiKhoan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_DoiTaiKhoan_ItemClick);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Caption = "Thoát";
            this.btn_Thoat.Id = 112;
            this.btn_Thoat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Thoat.ImageOptions.SvgImage")));
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // btn_LoaiSanPham
            // 
            this.btn_LoaiSanPham.Caption = "Loại sản phẩm";
            this.btn_LoaiSanPham.Id = 113;
            this.btn_LoaiSanPham.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_LoaiSanPham.ImageOptions.SvgImage")));
            this.btn_LoaiSanPham.Name = "btn_LoaiSanPham";
            this.btn_LoaiSanPham.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_LoaiSanPham_ItemClick);
            // 
            // btn_SanPham
            // 
            this.btn_SanPham.Caption = "Sản phẩm";
            this.btn_SanPham.Id = 114;
            this.btn_SanPham.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_SanPham.ImageOptions.SvgImage")));
            this.btn_SanPham.Name = "btn_SanPham";
            this.btn_SanPham.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_SanPham_ItemClick);
            // 
            // btn_HoaDon
            // 
            this.btn_HoaDon.Caption = "Hóa đơn";
            this.btn_HoaDon.Id = 115;
            this.btn_HoaDon.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_HoaDon.ImageOptions.SvgImage")));
            this.btn_HoaDon.Name = "btn_HoaDon";
            this.btn_HoaDon.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_HoaDon_ItemClick);
            // 
            // btn_ChiTietHoaDon
            // 
            this.btn_ChiTietHoaDon.Caption = "Chi tiết hóa đơn";
            this.btn_ChiTietHoaDon.Id = 116;
            this.btn_ChiTietHoaDon.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_ChiTietHoaDon.ImageOptions.SvgImage")));
            this.btn_ChiTietHoaDon.Name = "btn_ChiTietHoaDon";
            this.btn_ChiTietHoaDon.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_ChiTietHoaDon_ItemClick);
            // 
            // btn_ThayDoiServer
            // 
            this.btn_ThayDoiServer.Caption = "Thay đổi server";
            this.btn_ThayDoiServer.Id = 117;
            this.btn_ThayDoiServer.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_ThayDoiServer.ImageOptions.SvgImage")));
            this.btn_ThayDoiServer.Name = "btn_ThayDoiServer";
            this.btn_ThayDoiServer.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_ThayDoiServer_ItemClick);
            // 
            // btn_LoaiNhanVien
            // 
            this.btn_LoaiNhanVien.Caption = "Loại nhân viên";
            this.btn_LoaiNhanVien.Id = 118;
            this.btn_LoaiNhanVien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_LoaiNhanVien.ImageOptions.Image")));
            this.btn_LoaiNhanVien.Name = "btn_LoaiNhanVien";
            this.btn_LoaiNhanVien.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btn_LoaiNhanVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_LoaiNhanVien_ItemClick);
            // 
            // btn_TaiKhoan
            // 
            this.btn_TaiKhoan.Caption = "Tài khoản";
            this.btn_TaiKhoan.Id = 119;
            this.btn_TaiKhoan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_TaiKhoan.ImageOptions.Image")));
            this.btn_TaiKhoan.Name = "btn_TaiKhoan";
            this.btn_TaiKhoan.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btn_TaiKhoan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_TaiKhoan_ItemClick);
            // 
            // fileRibbonPage1
            // 
            this.fileRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.commonRibbonPageGroup1,
            this.ribbonPageGroup3,
            this.ribbonPageGroup4,
            this.ribbonPageGroup7});
            this.fileRibbonPage1.Name = "fileRibbonPage1";
            this.fileRibbonPage1.Text = "Quản lý";
            // 
            // commonRibbonPageGroup1
            // 
            this.commonRibbonPageGroup1.ItemLinks.Add(this.btn_NhanVien);
            this.commonRibbonPageGroup1.ItemLinks.Add(this.btn_LoaiNhanVien);
            this.commonRibbonPageGroup1.Name = "commonRibbonPageGroup1";
            this.commonRibbonPageGroup1.Text = "Nhân sự";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btn_LoaiSanPham);
            this.ribbonPageGroup3.ItemLinks.Add(this.btn_SanPham);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Kho";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btn_HoaDon);
            this.ribbonPageGroup4.ItemLinks.Add(this.btn_ChiTietHoaDon);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Bán hàng";
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.ItemLinks.Add(this.btn_TaiKhoan);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            this.ribbonPageGroup7.Text = "Tài khoản";
            // 
            // homeRibbonPage1
            // 
            this.homeRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup6});
            this.homeRibbonPage1.Name = "homeRibbonPage1";
            this.homeRibbonPage1.Text = "Hệ thống";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_ThongTinTaiKhoan);
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_DoiTaiKhoan);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Tài khoản";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.btn_Thoat);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "Thống kê";
            // 
            // repositoryItemDuration1
            // 
            this.repositoryItemDuration1.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.repositoryItemDuration1.AutoHeight = false;
            this.repositoryItemDuration1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDuration1.DisabledStateText = null;
            this.repositoryItemDuration1.Name = "repositoryItemDuration1";
            this.repositoryItemDuration1.NullValuePromptShowForEmptyValue = true;
            this.repositoryItemDuration1.ShowEmptyItem = true;
            this.repositoryItemDuration1.ValidateOnEnterKey = true;
            // 
            // repositoryItemSpinEdit1
            // 
            this.repositoryItemSpinEdit1.AutoHeight = false;
            this.repositoryItemSpinEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSpinEdit1.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.repositoryItemSpinEdit1.MaxValue = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.repositoryItemSpinEdit1.MinValue = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.siStatus);
            this.ribbonStatusBar.ItemLinks.Add(this.siInfo);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 663);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbonControl;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1100, 37);
            // 
            // saveScheduleItem2
            // 
            this.saveScheduleItem2.Caption = "Nhân viên";
            this.saveScheduleItem2.Id = 99;
            this.saveScheduleItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("saveScheduleItem2.ImageOptions.Image")));
            this.saveScheduleItem2.Name = "saveScheduleItem2";
            // 
            // saveScheduleItem3
            // 
            this.saveScheduleItem3.Caption = "Nhân viên";
            this.saveScheduleItem3.Id = 99;
            this.saveScheduleItem3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("saveScheduleItem3.ImageOptions.Image")));
            this.saveScheduleItem3.Name = "saveScheduleItem3";
            // 
            // saveScheduleItem4
            // 
            this.saveScheduleItem4.Caption = "Nhân viên";
            this.saveScheduleItem4.Id = 99;
            this.saveScheduleItem4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("saveScheduleItem4.ImageOptions.Image")));
            this.saveScheduleItem4.Name = "saveScheduleItem4";
            // 
            // saveScheduleItem5
            // 
            this.saveScheduleItem5.Caption = "Nhân viên";
            this.saveScheduleItem5.Id = 99;
            this.saveScheduleItem5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("saveScheduleItem5.ImageOptions.Image")));
            this.saveScheduleItem5.Name = "saveScheduleItem5";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_LoaiSanPham);
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_SanPham);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Common";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // Form1
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbonControl);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Ribbon = this.ribbonControl;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Admin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDuration1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.BarButtonItem iExit;
        private DevExpress.XtraBars.BarButtonItem iHelp;
        private DevExpress.XtraBars.BarButtonItem iAbout;
        private DevExpress.XtraBars.BarStaticItem siStatus;
        private DevExpress.XtraBars.BarStaticItem siInfo;
        private DevExpress.XtraBars.RibbonGalleryBarItem rgbiSkins;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraScheduler.UI.RepositoryItemDuration repositoryItemDuration1;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit1;
        private DevExpress.XtraScheduler.UI.FileRibbonPage fileRibbonPage1;
        private DevExpress.XtraScheduler.UI.CommonRibbonPageGroup commonRibbonPageGroup1;
        private DevExpress.XtraScheduler.UI.HomeRibbonPage homeRibbonPage1;
        private DevExpress.XtraScheduler.UI.SaveScheduleItem saveScheduleItem2;
        private DevExpress.XtraScheduler.UI.SaveScheduleItem saveScheduleItem3;
        private DevExpress.XtraScheduler.UI.SaveScheduleItem saveScheduleItem4;
        private DevExpress.XtraScheduler.UI.SaveScheduleItem saveScheduleItem5;
        private DevExpress.XtraBars.BarButtonItem btn_NhanVien;
        private DevExpress.XtraBars.BarButtonItem btn_ThongTinTaiKhoan;
        private DevExpress.XtraBars.BarButtonItem btn_DoiTaiKhoan;
        private DevExpress.XtraBars.BarButtonItem btn_Thoat;
        private DevExpress.XtraBars.BarButtonItem btn_LoaiSanPham;
        private DevExpress.XtraBars.BarButtonItem btn_SanPham;
        private DevExpress.XtraBars.BarButtonItem btn_HoaDon;
        private DevExpress.XtraBars.BarButtonItem btn_ChiTietHoaDon;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.BarButtonItem btn_ThayDoiServer;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btn_LoaiNhanVien;
        private DevExpress.XtraBars.BarButtonItem btn_TaiKhoan;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
    }
}
