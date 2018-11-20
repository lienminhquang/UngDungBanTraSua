using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.UserSkins;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Helpers;
using DevExpress.XtraScheduler;


namespace DXApplication1
{
    public partial class Form1 : RibbonForm
    {
        private string manv;

        public void setManv(string manv)
        {
            this.manv = manv;
        }

        public string getManv()
        { return manv; }

        
        private Form1()
        {
            InitializeComponent();
            InitSkinGallery();
            //schedulerControl.Start = System.DateTime.Now;
        }

        private static Form1 instance = null;

        public static Form1 Instance
        {
            get
            {
                if (instance == null)
                    instance = new Form1();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        void InitSkinGallery()
        {
            SkinHelper.InitSkinGallery(rgbiSkins, true);
        }

        private void btn_NhanVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Utility.f_NhanVien == null || Utility.f_NhanVien.IsDisposed)
            {
                Utility.f_NhanVien = new frm_NhanVien();
                Utility.f_NhanVien.MdiParent = this;
            }

           
            Utility.f_NhanVien.Show();

        }

        private void btn_LoaiNhanVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Utility.f_LoaiNhanVien == null || Utility.f_LoaiNhanVien.IsDisposed)
            {
                Utility.f_LoaiNhanVien = new frm_LoaiNhanVien();
                Utility.f_LoaiNhanVien.MdiParent = this;
            }


            Utility.f_LoaiNhanVien.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            foreach (var con in this.MdiChildren)
            {
                con.Close();
            }
        }

        private void btn_ChiTietHoaDon_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Utility.f_ChiTietHoaDon == null || Utility.f_ChiTietHoaDon.IsDisposed)
            {
                Utility.f_ChiTietHoaDon = new frm_ChiTietHoaDon();
                Utility.f_ChiTietHoaDon.MdiParent = this;
            }


            Utility.f_ChiTietHoaDon.Show();
        }

       

        private void btn_LoaiSanPham_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Utility.f_LoaiSanPham == null || Utility.f_LoaiSanPham.IsDisposed)
            {
                Utility.f_LoaiSanPham = new frm_LoaiSanPham();
                Utility.f_LoaiSanPham.MdiParent = this;
            }


            Utility.f_LoaiSanPham.Show();
        }

        private void btn_SanPham_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Utility.f_SanPham == null || Utility.f_SanPham.IsDisposed)
            {
                Utility.f_SanPham = new frm_SanPham();
                Utility.f_SanPham.MdiParent = this;
            }


            Utility.f_SanPham.Show();
        }

        private void btn_HoaDon_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Utility.f_HoaDon == null || Utility.f_HoaDon.IsDisposed)
            {
                Utility.f_HoaDon = new frm_HoaDon();
                Utility.f_HoaDon.MdiParent = this;
            }


            Utility.f_HoaDon.Show();
        }

        private void btn_TaiKhoan_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Utility.f_TaiKhoang == null || Utility.f_TaiKhoang.IsDisposed)
            {
                Utility.f_TaiKhoang = new frm_TaiKhoan();
                Utility.f_TaiKhoang.MdiParent = this;
            }


            Utility.f_TaiKhoang.Show();
        }

        private void btn_ThongTinTaiKhoan_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_ThongTinTaiKhoan f = new frm_ThongTinTaiKhoan();
            f.ShowDialog();
        }

        private void btn_ThayDoiServer_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_DoiServer f = new frm_DoiServer();
            f.ShowDialog();
        }

        private void btn_DoiTaiKhoan_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_DoiTaiKhoan f = new frm_DoiTaiKhoan();
            f.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}