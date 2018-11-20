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
    class BLTNhanVien
    {
        private BLTNhanVien()
        {

        }

        private static BLTNhanVien instance;

        internal static BLTNhanVien Instance
        {
            get
            {
                if (instance == null)
                    instance = new BLTNhanVien();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        public DataTable LayDS()
        {
            return DBMain.Instance.executeFunctionDataset(Cons.fn_DSNV).Tables[0];
        }

        public void Them(string ma, string ten, int cmnd,DateTime ngay, string loai)
        {
            List<SqlParameter> lstParam = new List<SqlParameter>();
            lstParam.Add(new SqlParameter("@ma", ma));
            lstParam.Add(new SqlParameter("@ten", ten));
            lstParam.Add(new SqlParameter("@cmnd", cmnd));
            lstParam.Add(new SqlParameter("@ngaysinh", ngay));
            lstParam.Add(new SqlParameter("@loai", loai));

            DBMain.Instance.executeStoredProc(Cons.p_ThemNV, lstParam);
        }

        public void Sua(string ma, string ten, int cmnd, DateTime ngay, string loai)
        {
            List<SqlParameter> lstParam = new List<SqlParameter>();
            lstParam.Add(new SqlParameter("@ma", ma));
            lstParam.Add(new SqlParameter("@ten", ten));
            lstParam.Add(new SqlParameter("@cmnd", cmnd));
            lstParam.Add(new SqlParameter("@ngaysinh", ngay));
            lstParam.Add(new SqlParameter("@loai", loai));

            DBMain.Instance.executeStoredProc(Cons.p_SuaNV, lstParam);
        }


        public void Xoa(string ma)
        {
            List<SqlParameter> lstParam = new List<SqlParameter>();
            lstParam.Add(new SqlParameter("@ma", ma));
            DBMain.Instance.executeStoredProc(Cons.p_XoaNV, lstParam);
        }

        public DataSet LayThongTinNhanVienvaTaiKhoan(string manv)
        {
            List<SqlParameter> lstParam = new List<SqlParameter>();
            lstParam.Add(new SqlParameter("@manv", manv));
           return DBMain.Instance.executeFunctionDataset(Cons.fn_LayThongTin, lstParam);
        }

        public string layTenNV(string ma)
        {
            List<SqlParameter> lstParam = new List<SqlParameter>();
            lstParam.Add(new SqlParameter("@manv", ma));
            return DBMain.Instance.executeFunctionDataset(Cons.fn_LayNhanVien, lstParam).Tables[0].Rows[0]["TenNV"].ToString();
        }
    }
}
