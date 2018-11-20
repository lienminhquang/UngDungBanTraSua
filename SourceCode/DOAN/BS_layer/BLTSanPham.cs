using DXApplication1.DB_layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication1.BS_layer
{
    class BLTSanPham
    {
        private BLTSanPham()
        {

        }

        private static BLTSanPham instance;

        internal static BLTSanPham Instance
        {
            get
            {
                if (instance == null)
                    instance = new BLTSanPham();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        public DataTable LayDS()
        {
            return DBMain.Instance.executeFunctionDataset(Cons.fn_DSSanPham).Tables[0];
        }

        public void Them(string ma, string maloai, string ten, string chitiet, string ghichu, int soluong, int gia)
        {
            List<SqlParameter> lstParam = new List<SqlParameter>();
            lstParam.Add(new SqlParameter("@ma", ma));
            lstParam.Add(new SqlParameter("@maloai", maloai));
            lstParam.Add(new SqlParameter("@ten", ten));
            lstParam.Add(new SqlParameter("@chitiet", chitiet));
            lstParam.Add(new SqlParameter("@ghichu", ghichu));
            lstParam.Add(new SqlParameter("@soluong", soluong));
            lstParam.Add(new SqlParameter("@gia", gia));
            DBMain.Instance.executeStoredProc(Cons.p_ThemSP, lstParam);
        }

        public void Sua(string ma, string maloai, string ten, string chitiet, string ghichu, int soluong, int gia)
        {
            List<SqlParameter> lstParam = new List<SqlParameter>();
            lstParam.Add(new SqlParameter("@ma", ma));
            lstParam.Add(new SqlParameter("@maloai", maloai));
            lstParam.Add(new SqlParameter("@ten", ten));
            lstParam.Add(new SqlParameter("@chitiet", chitiet));
            lstParam.Add(new SqlParameter("@ghichu", ghichu));
            lstParam.Add(new SqlParameter("@soluong", soluong));
            lstParam.Add(new SqlParameter("@gia", gia));
            DBMain.Instance.executeStoredProc(Cons.p_SuaSP, lstParam);
        }

        internal DataTable LayDSSPTheoLoai(string ma)
        {
            List<SqlParameter> lstParam = new List<SqlParameter>();
            lstParam.Add(new SqlParameter("@maloai", ma));
           return DBMain.Instance.executeFunctionDataset(Cons.fn_DSSanPhamTheoLoai, lstParam).Tables[0];
        }

        public void Xoa(string ma)
        {
            List<SqlParameter> lstParam = new List<SqlParameter>();
            lstParam.Add(new SqlParameter("@ma", ma));
            DBMain.Instance.executeStoredProc(Cons.p_XoaSP, lstParam);
        }

        public void NhapHang(string ma, int soluong)
        {
            List<SqlParameter> lstParam = new List<SqlParameter>();
            lstParam.Add(new SqlParameter("@ma", ma));
            lstParam.Add(new SqlParameter("@soluong", soluong));
            DBMain.Instance.executeStoredProc(Cons.p_NhapHang, lstParam);
        }

        public string layTenSP(string ma)
        {
            List<SqlParameter> lstParam = new List<SqlParameter>();
            lstParam.Add(new SqlParameter("@masp", ma));

            return DBMain.Instance.executeFunctionDataset(Cons.fn_LaySanPham, lstParam).Tables[0].Rows[0]["TenSP"].ToString();
        }
    }
}
