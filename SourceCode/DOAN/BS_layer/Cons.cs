using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication1.BS_layer
{

    

    class Cons
    {
        public static string fn_DNAdmin = "dbo.fn_DangNhapAdmin(@username, @password)";    
        public static string fn_LayDSTaiKhoan = "fn_LayDanhSachTaiKhoan()";
        public static string fn_login = "dbo.f_Login(@username, @password)";
        public static string p_SuaTK = "p_SuaTaiKhoan";
        public static string p_XoaTK = "p_XoaTaiKhoan";
        public static string p_DoiMK = "p_DoiMatKhau";
        public static string p_TaoTK = "p_TaoTK";
        public static string p_Admin_DoiMatKhau = "p_Admin_DoiMatKhau";


        public static string fn_DSLoaiSP = "fn_LayDanhSachLoaiSanPham()";
        public static string fn_LayLoai = "fn_LayLoai(@maloai)";
        public static string p_ThemLoaiSP = "p_ThemLoaiSP";
        public static string p_SuaLoaiSP = "p_SuaLoaiSP";
        public static string p_XoaLoaiSP = "p_XoaLoaiSP";


        public static string fn_DSSanPham = "fn_LayDanhSachSanPham()";
        public static string fn_DSSanPhamTheoLoai = "fn_LayDSSPTheoLoai(@maloai)";
        public static string fn_LaySanPham = "fn_LaySanPham(@masp)";
        public static string p_ThemSP = "p_ThemSanPham";
        public static string p_SuaSP = "p_SuaSanPham";
        public static string p_XoaSP = "p_XoaSanPham";
        public static string p_NhapHang = "p_NhapHang";


        public static string fn_DSHoaDon = "fn_LayDanhSachHoaDon()";
        public static string p_ThemHD = "p_ThemHoaDon";
        public static string p_SuaHD = "p_SuaHoaDon";
        public static string p_XoaHD = "p_XoaHoaDon";
        public static string fn_LayTongTien = "fn_LayTongTien(@mahd)";
        public static string pr_TuSinhMaHD = "pr_TuSinhMaHD(@mahd,@day)";

        public static string fn_DSCTHD = "fn_LayDanhSachChiTietHD()";
        public static string p_ThemCTHD = "p_ThemCTHD";
        public static string p_SuaCTHD = "p_SuaCTHD";
        public static string p_XoaCTHD = "p_XoaCTHD";
        public static string p_insertCTHD = "pr_insertCTHD";
        public static string fn_layViewCTHD = "fn_layViewCTHD (@mahd )";



        public static string fn_DSLoaiNV = "fn_LayDanhSachLoaiNhanVien()";
        public static string fn_LayLoaiNhanVien = "fn_LayLoaiNhanVien(@maloai)";
        public static string p_ThemLoaiNV = "p_ThemLoaiNhanVien";
        public static string p_SuaLoaiNV = "p_SuaLoaiNhanVien";
        public static string p_XoaLoaiNV = "p_XoaLoaiNhanVien";

        public static string fn_DSNV = "fn_LayDanhSachNhanVien()";
        public static string fn_LayNhanVien = "fn_LayNhanVien(@manv)";
        public static string p_ThemNV = "p_ThemNhanVien";
        public static string p_SuaNV = "p_SuaNhanVien";
        public static string p_XoaNV = "p_XoaNhanVien";
        public static string fn_LayThongTin = "fn_ThongTinTaiKhoan(@manv)";
    }
}
